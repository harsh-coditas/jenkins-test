using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Services.Contracts.PenaltyBox.EntityRemoval;
using ConnectAndSellSupport.Services.Extensions;
using ConnectAndSellSupport.Services.Helpers.Redis;
using ConnectAndSellSupport.Services.Helpers.TimeZone;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.PenaltyBox.EntityRemoval
{
    public class BadNumberRemovalService : IEntityRemovalService
    {
        #region Private members
        private readonly INumberFetcher _numberFetcher;
        private readonly IRedisCacheService _redisCacheService;
        #endregion

        #region Constructor
        public BadNumberRemovalService(
            INumberFetcher numberFetcher,
            IRedisCacheService redisCacheService)
        {
            _numberFetcher = numberFetcher;
            _redisCacheService = redisCacheService;
        }
        #endregion

        #region Private methods
        private async Task<RemovePenaltyBoxEntityServiceResponse> UpdateBadNumbers(IDictionary<string, SlimPhoneNumber> badNumberData)
        {
            foreach (var data in badNumberData)
            {
                data.Value.IsBad = false;
                data.Value.ModDate = TimeZoneHelper.GetPstTime();
            }

            await _redisCacheService.SetMultiAsync(badNumberData);

            return new RemovePenaltyBoxEntityServiceResponse
            {
                Success = true,
                UpdatedCount = badNumberData.Count                
            };
        }
        #endregion

        #region Interface implementations
        public Task<RemovePenaltyBoxEntityServiceResponse> RemoveEntity(RemovePenaltyBoxEntityRequest entityRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<RemovePenaltyBoxEntityServiceResponse> RemoveEntity(int companyId, List<RemovePenaltyBoxCsvRequest> entityRequests)
        {
            var (numbers, defaultedNumbers) = await _numberFetcher.FetchFormattedNumbersFromContacts(entityRequests);

            if (numbers.IsNullOrEmpty())
            {
                return new RemovePenaltyBoxEntityServiceResponse
                {
                    ContactsNotFound = true,
                    NumbersNotFound = defaultedNumbers
                };
            }

            var badNumberData = await _redisCacheService.GetMultiAsync<SlimPhoneNumber>(numbers);

            var redisNumbers = badNumberData.Select(d => d.Value?.PhoneNumber);

            var result = await UpdateBadNumbers(badNumberData);

            defaultedNumbers.ToList().AddRange(numbers.Except(redisNumbers));

            result.NumbersNotFound = defaultedNumbers;

            return result;
        }
        #endregion
    }
}
