using ConnectAndSellSupport.Services.Constants;
using System;

namespace ConnectAndSellSupport.Services.Helpers.TimeZone
{
    public static class TimeZoneHelper
    {
        public static DateTime? ConvertPstToUtc(DateTime? localTime)
        {
            if (!localTime.HasValue)
            {
                return default;
            }    
            
            var timeZone = TimeZoneInfo.FindSystemTimeZoneById(Constant.PacificStandardTimeKey);
            return TimeZoneInfo.ConvertTimeToUtc(localTime.Value, timeZone);
        }

        public static DateTime? ConvertUtcToPst(DateTime? localTime)
        {
            if (!localTime.HasValue)
            {
                return default;
            }

            var timeZone = TimeZoneInfo.FindSystemTimeZoneById(Constant.PacificStandardTimeKey);
            return TimeZoneInfo.ConvertTimeFromUtc(localTime.Value, timeZone);
        }

        public static DateTime GetPstTime()
        { 
            return ConvertUtcToPst(DateTime.UtcNow) ?? DateTime.Now;
        }
    }
}
