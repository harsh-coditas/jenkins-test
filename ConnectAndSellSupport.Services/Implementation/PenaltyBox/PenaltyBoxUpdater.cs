using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasPenalizedPhoneNumber;
using ConnectAndSellSupport.Repository.Contracts.CasPenaltyBoxAudit;
using ConnectAndSellSupport.Services.Contracts.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.PenaltyBox
{
    public class PenaltyBoxUpdater : IPenaltyBoxUpdater
    {
        private readonly ICasPenalizedPhoneNumberRepository _casPenalizedPhoneNumber;
        private readonly ICasPenaltyBoxAuditRepository _casPenaltyBoxAudit;

        public PenaltyBoxUpdater(
            ICasPenalizedPhoneNumberRepository casPenalizedPhoneNumber,

            ICasPenaltyBoxAuditRepository casPenaltyBoxAudit
            )
        {
            _casPenalizedPhoneNumber = casPenalizedPhoneNumber;
            _casPenaltyBoxAudit = casPenaltyBoxAudit;

        }

        public async Task<RemovePenaltyBoxEntityServiceResponse> UpdateEntity(PenaltyBoxServiceRequest entityRequest)
        {
            if (entityRequest == null)
            {
                return null;
            }
            var getPenalizedPhoneNumber = await _casPenalizedPhoneNumber.GetPenalizedPhoneNumber(entityRequest.penalizedNumberDetails.CompanyId, entityRequest.penalizedNumberDetails.StatusType, entityRequest.penalizedNumberDetails.FromDate, entityRequest.penalizedNumberDetails.ToDate, entityRequest.penalizedNumberDetails.ListIds, entityRequest.penalizedNumberDetails.UserIds);
            var getPenaltyBoxAudit = await _casPenaltyBoxAudit.GetPenaltyBoxAudit(entityRequest.penaltyBoxAuditDetails.CompanyId, entityRequest.penaltyBoxAuditDetails.StatusType, entityRequest.penaltyBoxAuditDetails.FromDate, entityRequest.penaltyBoxAuditDetails.ToDate, entityRequest.penaltyBoxAuditDetails.ListIds, entityRequest.penaltyBoxAuditDetails.UserIds);
            int penalizedPhoneNumberCount = getPenalizedPhoneNumber.Count();
            int penaltyBoxAuditCount = getPenaltyBoxAudit.Count();
            if (penalizedPhoneNumberCount == 0 && penaltyBoxAuditCount == 0)
            {
                return new RemovePenaltyBoxEntityServiceResponse
                {
                    ContactsNotFound = true,
                    Success = false


                };
            }
            var filteredPenalizedPhoneNumber = new List<CasPenalizedPhoneNumber>();
            if (getPenalizedPhoneNumber != null)
            {
                foreach (var penalized in getPenalizedPhoneNumber)
                {
                    penalized.IsDeleted = true;

                    filteredPenalizedPhoneNumber.Add(penalized);
                }
                await _casPenalizedPhoneNumber.UpdateMultiAsync(filteredPenalizedPhoneNumber);
            }

            var filterPenaltyBoxAUdit = new List<CasPenaltyBoxAudit>();
            if (getPenaltyBoxAudit != null)
            {
                foreach (var penalized in getPenaltyBoxAudit)
                {
                    penalized.IsDeleted = true;

                    filterPenaltyBoxAUdit.Add(penalized);
                }
                await _casPenaltyBoxAudit.UpdateMultiAsync(filterPenaltyBoxAUdit);


            }
            return new RemovePenaltyBoxEntityServiceResponse
            {
                UpdatedCount = getPenalizedPhoneNumber.Count(),
                Success = true


            };
        }
        public async Task<RemovePenaltyBoxEntityServiceResponse> RemovePhoneNumber(RemovePenaltyBoxbyPhoneNumberRequest phoneNumberRequest)
        {
            if (phoneNumberRequest == null)
            {
                return null;
            }
            var getPenalizedPhoneNumber = await _casPenalizedPhoneNumber.GetPenalizedPhoneNumberByPhoneNumber(phoneNumberRequest.PhoneNumber);
            var getPenaltyBoxPhoneNumber = await _casPenaltyBoxAudit.GetPenaltyBoxAuditByPhoneNumber(phoneNumberRequest.PhoneNumber);
            if (getPenalizedPhoneNumber != null)
            {
                var filteredPenalizedPhoneNumber = new List<CasPenalizedPhoneNumber>();
                foreach (var penalizedPhoneNumber in getPenalizedPhoneNumber)
                {
                    penalizedPhoneNumber.IsDeleted = true;
                    filteredPenalizedPhoneNumber.Add(penalizedPhoneNumber);

                }
                await _casPenalizedPhoneNumber.UpdateMultiAsync(filteredPenalizedPhoneNumber);
            }
            var filterPenaltyBoxAUdit = new List<CasPenaltyBoxAudit>();
            if (getPenaltyBoxPhoneNumber != null)
            {
                foreach (var penaltyBoxAuditPhoneNumber in getPenaltyBoxPhoneNumber)
                {
                    penaltyBoxAuditPhoneNumber.IsDeleted = true;

                    filterPenaltyBoxAUdit.Add(penaltyBoxAuditPhoneNumber);
                }
                await _casPenaltyBoxAudit.UpdateMultiAsync(filterPenaltyBoxAUdit);
            }

            return new RemovePenaltyBoxEntityServiceResponse
            {
                Success = true
            };
        }

        public async Task<RemovePenaltyBoxEntityServiceResponse> RemovePenaltyBoxById(RemovePenaltyBoxByIDRequest removePenaltyBoxByID)
        {
            if (removePenaltyBoxByID == null)
            {
                return null;
            }
            CasPenalizedPhoneNumber getPenalizedPhoneNumber = await _casPenalizedPhoneNumber.GetPenaltyBoxPhoneNumbersByIds(removePenaltyBoxByID.PenaltyBoxId);
            CasPenaltyBoxAudit getPenaltyBoxDetails = await _casPenaltyBoxAudit.GetPenaltyBoxAuditDetails(getPenalizedPhoneNumber.ContactId, getPenalizedPhoneNumber.CampaignName, getPenalizedPhoneNumber.FirstName, getPenalizedPhoneNumber.LastName, getPenalizedPhoneNumber.PhoneNumber);
            if (getPenalizedPhoneNumber != null)
            {
                var filteredPenalizedPhoneNumber = new List<CasPenalizedPhoneNumber>();

                getPenalizedPhoneNumber.IsDeleted = true;
                filteredPenalizedPhoneNumber.Add(getPenalizedPhoneNumber);


                await _casPenalizedPhoneNumber.UpdateMultiAsync(filteredPenalizedPhoneNumber);
            }

            var filterPenaltyBoxAUdit = new List<CasPenaltyBoxAudit>();
            if (getPenaltyBoxDetails != null)
            {

                getPenaltyBoxDetails.IsDeleted = true;

                filterPenaltyBoxAUdit.Add(getPenaltyBoxDetails);

                await _casPenaltyBoxAudit.UpdateMultiAsync(filterPenaltyBoxAUdit);
            }
            return new RemovePenaltyBoxEntityServiceResponse
            {
                Success = true
            };

        }
    }
}
