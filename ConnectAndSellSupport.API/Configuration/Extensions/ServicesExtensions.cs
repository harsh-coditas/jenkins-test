using ConnectAndSellSupport.API.Helpers.Reponse.ServiceResponseHandler.User;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ResponseHandler;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.Call;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.Company;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.List;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.PenaltyBox;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.User;
using ConnectAndSellSupport.API.Helpers.RequestGenerator;
using ConnectAndSellSupport.Domain.Models.Custom.Call;
using ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox;
using ConnectAndSellSupport.Services.Contracts.Call;
using ConnectAndSellSupport.Services.Contracts.Company;
using ConnectAndSellSupport.Services.Contracts.List;
using ConnectAndSellSupport.Services.Contracts.PenaltyBox;
using ConnectAndSellSupport.Services.Contracts.PenaltyBox.EntityRemoval;
using ConnectAndSellSupport.Services.Contracts.User;
using ConnectAndSellSupport.Services.Contracts.Data;
using ConnectAndSellSupport.Services.Helpers;
using ConnectAndSellSupport.Services.Helpers.Formatter.PhoneNumber;
using ConnectAndSellSupport.Services.Helpers.Password;
using ConnectAndSellSupport.Services.Implementation.Call;
using ConnectAndSellSupport.Services.Implementation.Company;
using ConnectAndSellSupport.Services.Implementation.List;
using ConnectAndSellSupport.Services.Implementation.PenaltyBox;
using ConnectAndSellSupport.Services.Implementation.PenaltyBox.EntityRemoval;
using ConnectAndSellSupport.Services.Implementation.User;
using ConnectAndSellSupport.Services.Models.Response.Call;
using ConnectAndSellSupport.Services.Models.Response.Company;
using ConnectAndSellSupport.Services.Models.Response.List;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response.User;
using Microsoft.Extensions.DependencyInjection;
using ConnectAndSellSupport.Services.Implementation.Data;
using ConnectAndSellSupport.Services.Models.Response.Data;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.Data;
using ConnectAndSellSupport.Services.Contracts.Job;
using ConnectAndSellSupport.Services.Implementation.Job;
using ConnectAndSellSupport.Services.Models.Response.Job;
using ConnectAndSellSupport.API.Helpers.ReponseGenerator.ServiceResponseHandler.Job;
using ConnectAndSellSupport.Services.CsvMapper;
using ConnectAndSellSupport.Repository.Factory;

namespace ConnectAndSellSupport.API.Configuration.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureLocalServicesAndHelpers(this IServiceCollection services)
        {
            #region Configure API helpers
            services.AddScoped<IRequestFactory, RequestFactory>();
            services.AddScoped<IResponseFactory, ResponseFactory>();

            services.AddTransient<UserAuthResponseHandler>();
            services.AddTransient<RefreshTokenResponseHandler>();
            services.AddTransient<AgentCallRecordResponseHandler>();
            services.AddTransient<PitcherConversationRecordResponseHandler>();
            services.AddTransient<PitcherConversationUpdateRecordResponseHandler>();
            services.AddTransient<CompanyDispositionResponseHandler>();
            services.AddTransient<CompanyResponseHandler>();
            services.AddTransient<UserResponseHandler>();
            services.AddTransient<ListResponseHandler>();
            services.AddTransient<ListsUpdateResponseHandler>();
            services.AddTransient<RemovePenaltyBoxResponseHandler>();
            services.AddTransient<RemovePenaltyBoxBulkResponseHandler>();
            services.AddTransient<GetReplenishmentResponseHandler>();
            services.AddTransient<JobResponseHandler>();
            services.AddTransient<PenalizedPhoneNumberHandler>();
            services.AddTransient<ServiceReponseHandlerResolver>(
                serviceProvider => serviceResponse =>
                {
                    return serviceResponse switch
                    {
                        LoginServiceResponse =>
                            serviceProvider.GetService<UserAuthResponseHandler>(),
                        RefreshTokenServiceResponse =>
                            serviceProvider.GetService<RefreshTokenResponseHandler>(),
                        CallRecordServiceResponse callRecordServiceResponse =>
                            callRecordServiceResponse.CallType.Equals(CallType.Agent)
                                ? serviceProvider.GetService<AgentCallRecordResponseHandler>()
                                : serviceProvider.GetService<PitcherConversationRecordResponseHandler>(),
                        PitcherCallRecordUpdateServiceResponse callRecordUpdateServiceResponse =>
                            serviceProvider.GetService<PitcherConversationUpdateRecordResponseHandler>(),
                        CompanyDispositionServiceResponse =>
                            serviceProvider.GetService<CompanyDispositionResponseHandler>(),
                        CompanyServiceResponse =>
                            serviceProvider.GetService<CompanyResponseHandler>(),
                        UserServiceResponse =>
                            serviceProvider.GetService<UserResponseHandler>(),
                        ListServiceResponse =>
                            serviceProvider.GetService<ListResponseHandler>(),
                        ListsUpdateServiceResponse =>
                            serviceProvider.GetService<ListsUpdateResponseHandler>(),
                        RemovePenaltyBoxEntityServiceResponse =>
                            serviceProvider.GetService<RemovePenaltyBoxResponseHandler>(),
                        RemovePenaltyBoxEntityBulkServiceResponse =>
                            serviceProvider.GetService<RemovePenaltyBoxBulkResponseHandler>(),
                        ReplenishmentServiceResponse =>
                            serviceProvider.GetService<GetReplenishmentResponseHandler>(),
                        PenaltyBoxDetailsResponse=>
                        serviceProvider.GetService<PenalizedPhoneNumberHandler>(),
                    JobsRecordServiceResponse =>
                            serviceProvider.GetService<JobResponseHandler>(),
                        _ => null
                    };
                });
            #endregion

            services.AddScoped<ITokenHelper, TokenHelper>();
            services.AddScoped<IPasswordHelper, PasswordHelper>();
            services.AddScoped<IPhoneNumberFormatHelper, PhoneNumberFormatHelper>();

            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IUserFetcher, UserFetcher>();

            services.AddScoped<ICallRecordFetcher, CallRecordFetcher>();
            services.AddScoped<ICallRecordUpdater, CallRecordUpdater>();
            services.AddScoped<ITCallService, TCallService>();
            services.AddScoped<ICasNoteService, CasNoteService>();

            services.AddScoped<ICompanyConfigurationFetcher, CompanyConfigurationFetcher>();
            services.AddScoped<ICompanyFetcher, CompanyFetcher>();
            services.AddScoped<ICompanySettingsUpdater, CompanySettingsUpdater>();
            services.AddScoped<ICompanySettingsDetailsUpdater, CompanySettingsDetailsUpdater>();

            services.AddScoped<IListFetcher, ListFetcher>();
            services.AddScoped<IListUpdater, ListUpdater>();
            services.AddScoped<IPenaltyBoxUpdater, PenaltyBoxUpdater>();
            services.AddScoped<IPenaltyBoxRemovalService, PenaltyBoxRemovalService>();
            services.AddScoped<IReplenishmentService, ReplenishmentService>();

            services.AddScoped<IContactFetcher, ContactFetcher>();
            services.AddScoped<INumberFetcher, NumberFetcher>();
            services.AddScoped<IPenaltyBoxFetcher, PenaltyBoxFetcher>();


            services.AddTransient<IJobsRecordFetcher, JobRecordFetcher>();

            services.AddTransient<DncRemovalService>();
            services.AddTransient<MalformedNumberRemovalService>();
            services.AddTransient<WrongNumberRemovalService>();
            services.AddTransient<BadNumberRemovalService>();

            services.AddScoped<ICSVService, CSVService>();

            services.AddScoped<IUserBulkUploadService, UserBulkUploadService>();
            services.AddScoped<SQLBulkFactory>();

            services.AddTransient<EntityRemovalServiceResolver>(
                serviceProvider => entityType =>
                {
                    return entityType switch
                    {
                        PenaltyBoxEntityType.DNC =>
                            serviceProvider.GetService<DncRemovalService>(),
                        PenaltyBoxEntityType.MalformedNumber =>
                            serviceProvider.GetService<MalformedNumberRemovalService>(),
                        PenaltyBoxEntityType.WrongNumber =>
                            serviceProvider.GetService<WrongNumberRemovalService>(),
                        PenaltyBoxEntityType.BadNumber =>
                            serviceProvider.GetService<BadNumberRemovalService>(),
                        _ => null
                    };
                });
        }
    }
}
