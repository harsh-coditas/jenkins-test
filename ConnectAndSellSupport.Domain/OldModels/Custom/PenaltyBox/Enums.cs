using System.ComponentModel;

namespace ConnectAndSellSupport.Domain.Models.Custom.PenaltyBox
{
    public enum PenaltyBoxEntityType : byte
    {
        [Description("DNC Number")]
        DNC,
        [Description("Malformed Number")]
        MalformedNumber,
        [Description("Wrong Number")]
        WrongNumber,
        [Description("Bad Number")]
        BadNumber
    }
}
