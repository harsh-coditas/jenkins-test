using ConnectAndSellSupport.Repository.Contracts;
using ConnectAndSellSupport.Repository.Contracts.CasCompanyDisposition;
using ConnectAndSellSupport.Repository.Contracts.CasCompanySetting;
using ConnectAndSellSupport.Repository.Contracts.CasCompanySettingDetail;
using ConnectAndSellSupport.Repository.Contracts.CasContact;
using ConnectAndSellSupport.Repository.Contracts.CasContactUserReplenishment;
using ConnectAndSellSupport.Repository.Contracts.CasJobTriggeredDetails;
using ConnectAndSellSupport.Repository.Contracts.CasList;
using ConnectAndSellSupport.Repository.Contracts.CasListContact;
using ConnectAndSellSupport.Repository.Contracts.CasNote;
using ConnectAndSellSupport.Repository.Contracts.CasPenalizedPhoneNumber;
using ConnectAndSellSupport.Repository.Contracts.CasPenaltyBoxAudit;
using ConnectAndSellSupport.Repository.Contracts.CasUser;
using ConnectAndSellSupport.Repository.Contracts.TCall;
using ConnectAndSellSupport.Repository.Contracts.TCompany;
using ConnectAndSellSupport.Repository.Contracts.TCountryInfo;
using ConnectAndSellSupport.Repository.Contracts.TDnc;
using ConnectAndSellSupport.Repository.Contracts.TUser;
using ConnectAndSellSupport.Repository.Implementation;
using ConnectAndSellSupport.Repository.Implementation.CasCompanyDisposition;
using ConnectAndSellSupport.Repository.Implementation.CasCompanySetting;
using ConnectAndSellSupport.Repository.Implementation.CasCompanySettingDetail;
using ConnectAndSellSupport.Repository.Implementation.CasContact;
using ConnectAndSellSupport.Repository.Implementation.CasJobTriggeredDetails;
using ConnectAndSellSupport.Repository.Implementation.CasList;
using ConnectAndSellSupport.Repository.Implementation.CasListContact;
using ConnectAndSellSupport.Repository.Implementation.CasNote;
using ConnectAndSellSupport.Repository.Implementation.CasPenalizedPhoneNumber;
using ConnectAndSellSupport.Repository.Implementation.CasPenaltyBoxAudit;
using ConnectAndSellSupport.Repository.Implementation.CasReplenishment;
using ConnectAndSellSupport.Repository.Implementation.CasUser;
using ConnectAndSellSupport.Repository.Implementation.TCall;
using ConnectAndSellSupport.Repository.Implementation.TCompany;
using ConnectAndSellSupport.Repository.Implementation.TCountryInfo;
using ConnectAndSellSupport.Repository.Implementation.TDnc;
using ConnectAndSellSupport.Repository.Implementation.TUser;
using ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.CasList;
using ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.CasNote;
using ConnectAndSellSupport.Repository.ReplicaRepository.Contracts.TCall;
using ConnectAndSellSupport.Repository.ReplicaRepository.Implemenation.CasList;
using ConnectAndSellSupport.Repository.ReplicaRepository.Implemenation.CasNote;
using ConnectAndSellSupport.Repository.ReplicaRepository.Implemenation.TCall;
using ConnectAndSellSupport.Services.Contracts.Job;
using ConnectAndSellSupport.Services.Implementation.Job;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectAndSellSupport.API.Configuration
{
    public static class RepositoryConfiguration
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITUserRepository, TUserRepository>();
            services.AddScoped<ICasUserRepository, CasUserRepository>();
            services.AddScoped<ITCallRepository, TCallRepository>();
            services.AddScoped<ITCallReplicaRepository, TCallReplicaRepository>();
            services.AddScoped<ICasNoteRepository, CasNoteRepository>();
            services.AddScoped<ICasNoteReplicaRepository, CasNoteReplicaRepository>();
            services.AddScoped<ICasListRepository, CasListRepository>();
            services.AddScoped<ICasListReplicaRepository, CasListReplicaRepository>();
            services.AddScoped<ICasCompanyDispositionRepository, CasCompanyDispositionRepository>();
            services.AddScoped<ICasCompanySettingRepository, CasCompanySettingRepository>();
            services.AddScoped<ICasCompanySettingDetailRepository, CasCompanySettingDetailRepository>();
            services.AddScoped<ITCompanyRepository, TCompanyRepository>();
            services.AddScoped<ITDncRepository, TDncRepository>();
            services.AddScoped<ITDncArchiveRepository, TDncArchiveRepository>();
            services.AddScoped<ICasContactRepository, CasContactRepository>();
            services.AddScoped<ICasListContactRepository, CasListContactRepository>();
            services.AddScoped<ITCountryInfoRepository, TCountryInfoRepository>();
            services.AddScoped<ICasReplenishmentRepository, CasReplenishmentRepository>();
            services.AddScoped<IJobsRecordFetcher, JobRecordFetcher>();
            services.AddScoped<ICasJobTriggeredDetails, CasJobTriggeredDetailsRepository>();
            services.AddScoped<ICasPenalizedPhoneNumberRepository, CasPenalizedPhoneNumberRepository>();
            services.AddScoped<ICasPenaltyBoxAuditRepository, CasPenaltyBoxAuditRepository>();
           

            services.AddScoped<ISQLBulkOperation, SQLBulkOperation>();
        }
    }
}       
