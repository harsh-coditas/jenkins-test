using ConnectAndSellSupport.API.Authorization;
using ConnectAndSellSupport.API.Configuration;
using ConnectAndSellSupport.API.Configuration.Extensions;
using ConnectAndSellSupport.API.Configuration.Models;
using ConnectAndSellSupport.API.Configuration.OperationFilters;
using ConnectAndSellSupport.API.Models;
using ConnectAndSellSupport.API.Validations.Filters;
using ConnectAndSellSupport.Domain.Models;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using ConnectAndSellSupport.Domain.Models.Custom.User;
using ConnectAndSellSupport.API.Constants;
using ConnectAndSellSupport.Domain;
using ConnectAndSellSupport.Services.Helpers;

namespace ConnectAndSellSupport.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers(options =>
            {
                options.Filters.Add(new PayLoadValidationFilter());
            }).ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            }).AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssemblyContaining<Startup>();
            }).AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new TypeIgnoringConverter());
            });

            services.AddMvc().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "ConnectAndSellSupport.API",
                    Version = "v1"
                });

                c.OperationFilter<HeaderParameter>();

                // To Enable authorization using Swagger (JWT)    
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "access token",
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            Array.Empty<string>()
                    }
                });
            });

            services.AddSingleton<IAuthorizationHandler, CasRolesAuthorizationHandler>();
            services.AddAuthorization(options =>
            {
                options.AddPolicy(Policies.AdminAndEngineering, policy =>
                    policy.Requirements.Add(new CasRolesRequirement(Roles.Administrator, Roles.Engineering)));
            });

            var dbSettingsSection = Configuration.GetSection("DBSettings");
            services.Configure<List<DBSetting>>(dbSettingsSection);

            var replicaDbSettingsSection = Configuration.GetSection("ReplicaDBSettings");
            services.Configure<List<ReplicaDBSetting>>(replicaDbSettingsSection);

            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            services.ConfigureLocalServicesAndHelpers();
            services.ConfigureRepositories();
            services.ConfigureAutomapper();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ConnectionStringBuilder>();
            services.AddDbContext<CASContext>((serviceProvider, dbContextBuilder) =>
            {
                var csBuilder = serviceProvider.GetRequiredService<ConnectionStringBuilder>();
                string connectionString = csBuilder.GetConnectionString();
                dbContextBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
            });
            services.AddDbContext<CASReplicaContext>((serviceProvider, dbContextBuilder) =>
            {
                var csBuilder = serviceProvider.GetRequiredService<ConnectionStringBuilder>();
                string connectionString = csBuilder.GetReplicaConnectionString();
                dbContextBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
            });

            services.ConfigureRedis(Configuration);

            SetupJWTAuthentication(services, appSettingsSection);
        }

        private static void SetupJWTAuthentication(IServiceCollection services, IConfigurationSection appSettingsSection)
        {
            var appSettings = appSettingsSection.Get<AppSettings>();
            var secretKey = Encoding.ASCII.GetBytes(appSettings.JWTSecretKey);
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(jwtBearerOptions =>
            {
                jwtBearerOptions.RequireHttpsMetadata = false;
                jwtBearerOptions.SaveToken = true;
                jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(secretKey),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.FromMinutes(1),
                    ValidateLifetime = true
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ConnectAndSellSupport.API v1"));
            }

            app.UseCors(x => x
                 .AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
