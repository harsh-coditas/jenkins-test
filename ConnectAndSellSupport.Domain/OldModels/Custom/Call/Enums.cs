using System.ComponentModel;

namespace ConnectAndSellSupport.Domain.Models.Custom.Call
{
    public enum CallType : byte
    {
        Agent = 1,
        Pitcher = 2
    }

    public enum SessionType : byte
    {
        Classic,
        Direct,
        ClassicDialer,
        OnSiteTrial,
        DirectDialer,
        Lightning,
        LightningDialer,
        NativeLightning,
        NativeDialer,
        COLV
    }

    public enum CSVLeadStatus : byte
    {
        [Description("Not Contacted")]
        NotContacted,
        [Description("Contacted - Qualifying")]
        ContactedQualifying,
        [Description("Contacted - Disqualified")]
        ContactedDisqualified
    };
}
