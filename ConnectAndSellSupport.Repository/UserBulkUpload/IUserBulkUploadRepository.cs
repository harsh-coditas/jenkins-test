using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.UserBulkUpload
{
    public interface IUserBulkUploadRepository
    {
        bool BulkSaveUser(List<UserBulkUploadDBModelTCas> model);
        bool BulkUploadCasUser(List<UserBulkUploadDBModelCUser> casModel);
        Task<IEnumerable<TUser>> BulkGetTUserId(List<string> EmailIds, string Password, long unixTime);
    }
}
