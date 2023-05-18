using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Models.Response.Job
{
    public class JobDetailsResponse 
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string jobstatus { get; set; }

        public DateTime? startTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string InnerExceptionMessage { get; set; }
    }
}
