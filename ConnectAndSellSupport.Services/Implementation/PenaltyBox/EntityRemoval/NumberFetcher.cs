using ConnectAndSellSupport.Services.Contracts.PenaltyBox.EntityRemoval;
using ConnectAndSellSupport.Services.Extensions;
using ConnectAndSellSupport.Services.Helpers.Formatter.PhoneNumber;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.PenaltyBox.EntityRemoval
{
    public class NumberFetcher : INumberFetcher
    {
        #region Private members
        private readonly IContactFetcher _contactFetcher;
        private readonly IPhoneNumberFormatHelper _phoneNumberFormatHelper;
        #endregion

        #region Constructor
        public NumberFetcher(
            IContactFetcher contactFetcher,
            IPhoneNumberFormatHelper phoneNumberFormatHelper)
        {
            _contactFetcher = contactFetcher;
            _phoneNumberFormatHelper = phoneNumberFormatHelper;
        }
        #endregion

        #region Interface implementations
        public async Task<(IEnumerable<string> Numbers, IEnumerable<string> DefaultedNumbers)> FetchFormattedNumbersFromContacts(RemovePenaltyBoxEntityRequest entityRequest)
        {            
            var contacts = await _contactFetcher.FetchContacts(entityRequest);

            var contactNumbers = contacts?
                .SelectMany(c => new[]
                {
                    (c.Phone1, c.ContactCountry),
                    (c.Phone2, c.ContactCountry)
                });

            return await _phoneNumberFormatHelper.GetNumbersWithInternationCode(contactNumbers);
        }

        public async Task<(IEnumerable<string> Numbers, IEnumerable<string> DefaultedNumbers)> FetchFormattedNumbersFromContacts(List<RemovePenaltyBoxCsvRequest> entityRequests)
        {
            if (entityRequests.IsNullOrEmpty())
            {
                return default;
            }

            var requestPhoneNumbers = entityRequests.Select(c => new { c.ContactId, c.PhoneNumber });

            var contacts = await _contactFetcher.FetchContacts(entityRequests);

            if (contacts.IsNullOrEmpty())
            {
                return default;
            }

            var contactContries = contacts.ToDictionary(c => c.ContactId, c => c.ContactCountry);            

            var requestContactNumbers = new List<(string contactNumber, string countryName)>();

            foreach (var number in requestPhoneNumbers)
            {
                if (contactContries.TryGetValue(number.ContactId, out var country))
                {
                    requestContactNumbers.Add(new(number.PhoneNumber, country));
                }
            }

            return await _phoneNumberFormatHelper.GetNumbersWithInternationCode(requestContactNumbers);
        }
        #endregion
    }
}
