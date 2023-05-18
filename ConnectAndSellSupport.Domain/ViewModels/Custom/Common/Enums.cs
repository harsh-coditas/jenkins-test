using System.ComponentModel;

namespace ConnectAndSellSupport.Domain.Models.Custom.Common
{
    public enum FileExtension : byte
    {
        [Description(".csv")]
        Csv
    };
}
