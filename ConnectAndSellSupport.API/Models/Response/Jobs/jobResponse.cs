using System.Text.Json.Serialization;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace ConnectAndSellSupport.API.Models.Response.Jobs
{
    public class jobResponse
    {
        [JsonPropertyName("jobname")]
        public string JobName { get; set; }
        [JsonPropertyName("jobstatus")]
        public string jobstatus { get; set; }
        [JsonPropertyName("startTime")]
        public System.Nullable<System.DateTime> startTime { get; set; }
        [JsonPropertyName("endTime")]
        public System.Nullable<System.DateTime> EndTime { get; set; }
        [JsonPropertyName("InnerExceptionMessage")]
        public string InnerExceptionMessage { get; set; }

    }
}
