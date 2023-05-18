using AutoMapper;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Services.Models.Response.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Automapper.job
{
    public class JobProfile :Profile
    {
        public JobProfile()
        {
            CreateMap<CasJobsTriggeredDetail, JobDetailsResponse>();
        }
    }
}
