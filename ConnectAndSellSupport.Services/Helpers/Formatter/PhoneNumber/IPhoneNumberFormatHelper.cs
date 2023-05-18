using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Helpers.Formatter.PhoneNumber
{
    public interface IPhoneNumberFormatHelper
    {
        Task<(IEnumerable<string> Numbers, IEnumerable<string> DefaultedNumbers)> GetNumbersWithInternationCode(IEnumerable<(string contactNumber, string countryName)> values);        
    }
}
