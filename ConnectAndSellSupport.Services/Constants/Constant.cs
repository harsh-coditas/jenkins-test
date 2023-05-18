using System;

namespace ConnectAndSellSupport.Services.Constants
{
    public static class Constant
    {
        public const int PasswordAttemptThreshold = 5;

        public static readonly DateTime TCallDefaultDateTime = new(2001, 01,01);

        public const string PacificStandardTimeKey = "Pacific Standard Time";

        public const string UnitedStatesRegion = "United States";

        public const string MalformedNumberStatus = "Malformed-Number";
    }
}
