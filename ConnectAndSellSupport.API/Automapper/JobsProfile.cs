using AutoMapper;
using ConnectAndSellSupport.API.Models.Response.Company;
using ConnectAndSellSupport.API.Models.Response.Jobs;
using ServiceModels=ConnectAndSellSupport.Services.Models.Response.Job;
using ConnectAndSellSupport.Services.Models.Response.Job;

namespace ConnectAndSellSupport.API.Automapper
{
    public class JobsProfile :Profile
    {
        public JobsProfile()
        {
            CreateMap<JobDetailsResponse, jobResponse>();
        }
        
        
    }
}
