using ConnectAndSellSupport.Services.Models.Response.PenaltyBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Contracts.PenaltyBox
{
    public interface IPenaltyBoxFetcher
    {
        Task<PenaltyBoxDetailsResponse> GetPenaltyBoxByNumber(string PhoneNumber);

       
    }
}
