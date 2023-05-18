using ConnectAndSellSupport.Repository.Contracts.TCountryInfo;
using ConnectAndSellSupport.Services.Constants;
using ConnectAndSellSupport.Services.Extensions;
using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Helpers.Formatter.PhoneNumber
{
    public class PhoneNumberFormatHelper : IPhoneNumberFormatHelper
    {
        #region Private methods
        private readonly PhoneNumberUtil _phoneNumberUtil;
        private readonly ITCountryInfoRepository _tCountryInfoRepository;
        #endregion

        #region Constructor
        public PhoneNumberFormatHelper(
            ITCountryInfoRepository tCountryInfoRepository)
        {
            _phoneNumberUtil = PhoneNumberUtil.GetInstance();
            _tCountryInfoRepository = tCountryInfoRepository;
        }
        #endregion

        #region Interface implementations
        public async Task<(IEnumerable<string> Numbers, IEnumerable<string> DefaultedNumbers)> GetNumbersWithInternationCode(IEnumerable<(string contactNumber, string countryName)> values)
        {
            try
            {
                var countryNames = values.Select(v => v.countryName);

                if (countryNames.IsNullOrEmpty())
                {
                    return default;
                }

                var countries = await _tCountryInfoRepository.GetByNames(countryNames.ToHashSet());
                var countriesDict = countries.ToDictionary(c => c.Name, c => c.Iso2Code);

                var numbers = new List<string>();
                var defaultedNumbers = new List<string>();

                foreach (var (contactNumber, countryName) in values)
                {
                    if (!string.IsNullOrWhiteSpace(contactNumber))
                    {
                        var number = PhoneNumberUtil.ExtractPossibleNumber(contactNumber);
                        var country = string.Empty;
                        if (number != default &&
                            PhoneNumberUtil.IsViablePhoneNumber(number))
                        {
                            if(string.IsNullOrWhiteSpace(countryName) || 
                                !countriesDict.TryGetValue(countryName, out country))
                            {
                                country = Constant.UnitedStatesRegion;
                            }

                            if (_phoneNumberUtil.IsPossibleNumber(number, country))
                            {
                                var phoneNumber = _phoneNumberUtil.ParseAndKeepRawInput(number, country);
                                if (phoneNumber != null)
                                {
                                    numbers.Add(string.Concat("+", phoneNumber.CountryCode, phoneNumber.NationalNumber));
                                }
                            }
                            else
                            {
                                defaultedNumbers.Add(contactNumber);
                            }
                        }
                        else
                        {
                            defaultedNumbers.Add(contactNumber);
                        }
                    }
                }

                return (numbers, defaultedNumbers);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
