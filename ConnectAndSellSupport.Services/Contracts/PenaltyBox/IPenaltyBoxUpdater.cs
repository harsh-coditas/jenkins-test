using ConnectAndSellSupport.Services.Models.Request.PenaltyBox;
using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.PenaltyBox
{
    public interface IPenaltyBoxUpdater
    {
        Task<RemovePenaltyBoxEntityServiceResponse> UpdateEntity(PenaltyBoxServiceRequest entityRequest);
        Task<RemovePenaltyBoxEntityServiceResponse> RemovePhoneNumber(RemovePenaltyBoxbyPhoneNumberRequest phoneNumberRequest);

        Task<RemovePenaltyBoxEntityServiceResponse> RemovePenaltyBoxById(RemovePenaltyBoxByIDRequest removePenaltyBoxByID);

    }
}
