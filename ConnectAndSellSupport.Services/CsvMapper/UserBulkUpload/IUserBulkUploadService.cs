using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Domain.Models.Custom.User;
using ConnectAndSellSupport.Domain.ViewModels;
using ConnectAndSellSupport.Repository.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.CsvMapper
{
    public interface IUserBulkUploadService
    {
        (bool, List<UserUploadError>) BulkSaveUser(IFormFileCollection file, int companyId, Roles[] roleId);
    }
}
