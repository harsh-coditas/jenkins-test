using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.TUser;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConnectAndSellSupport.Repository.Implementation.TUser
{
    public class TUserRepository : Repository<Domain.Models.TUser>, ITUserRepository
    {
        private const string _bulkcopy_destination_tbl_name = "t_User";
        public TUserRepository(CASContext context) : base(context)
        {
        }

        public async Task<Domain.Models.TUser> GetById(int id)
        {
            if (id == default)
            {
                return default;
            }

            return await GetSingleAsync(u =>
                u.Id.Equals(id) &&
                (!u.IsDeleted.HasValue || !u.IsDeleted.Value));
        }

        public async Task<IEnumerable<Domain.Models.TUser>> GetByIds(HashSet<int> ids)
        {
            if (ids == default)
            {
                return default;
            }

            return await GetMultiAsync(u =>
                ids.Contains(u.Id) &&
                (!u.IsDeleted.HasValue || !u.IsDeleted.Value));
        }

        public async Task<Domain.Models.TUser> GetByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return default;
            }

            return await GetSingleAsync(u => 
                (u.UserName.Equals(username) || u.LoginId.Equals(username)) && 
                (!u.IsDeleted.HasValue || !u.IsDeleted.Value));
        }

        public async Task<IEnumerable<Domain.Models.TUser>> GetByCompanyId(int companyId)
        {
            if (companyId == default)
            {
                return default;
            }

            return await GetMultiAsync(u => 
                u.CompanyId.Equals(companyId) &&
                (!u.IsDeleted.HasValue || !u.IsDeleted.Value));
        }


    }
}
