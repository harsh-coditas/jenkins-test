using AutoMapper;
using ConnectAndSellSupport.Repository.Contracts.CasPenalizedPhoneNumber;
using ConnectAndSellSupport.Repository.Contracts.CasPenaltyBoxAudit;
using ConnectAndSellSupport.Services.Contracts.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.PenaltyBox
{
    public class PenaltyBoxFetcher : IPenaltyBoxFetcher
    {
        private readonly ICasPenalizedPhoneNumberRepository _casPenalizedPhoneNumberRepository;
        private readonly ICasPenaltyBoxAuditRepository _casPenaltyBoxAudit;
        private readonly IMapper _mapper;
        public PenaltyBoxFetcher(ICasPenalizedPhoneNumberRepository casPenalizedPhoneNumberRepository,
           ICasPenaltyBoxAuditRepository casPenaltyBoxAudit, IMapper mapper
           )
        {
            _casPenalizedPhoneNumberRepository = casPenalizedPhoneNumberRepository;
            _casPenaltyBoxAudit = casPenaltyBoxAudit;
            _mapper = mapper;
        }
        public async Task<PenaltyBoxDetailsResponse> GetPenaltyBoxByNumber(string PhoneNumber)
        {
            if(PhoneNumber == null)
            {
                return null;
            }
            var response = new PenaltyBoxDetailsResponse();
            var PenalizedNumber = await _casPenalizedPhoneNumberRepository.GetPenalizedPhoneNumberByPhoneNumber(PhoneNumber);
            var PenaltyBox = await _casPenaltyBoxAudit.GetPenaltyBoxAuditByPhoneNumber(PhoneNumber);
            int penalizedNumberCount = PenalizedNumber.Count();
            int penaltyBoxNumberCount = PenaltyBox.Count();
            if (penalizedNumberCount == 0 && penaltyBoxNumberCount == 0)
            {
                response.ContactNotFound = true;
                return response;
            }
            response.CasPenalizedPhoneNumberDetails = _mapper.Map<List<CasPenalizedPhoneNumberDetailsResponse>>(PenalizedNumber);
            response.CasPenaltyBoxDetails = _mapper.Map<List<CasPenaltyBoxDetailsResponse>>(PenaltyBox);
            response.Success = true;
            return response;

        }

    }
}
