using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasUser;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Implementation.CasUser
{
    public class CasUserRepository : Repository<Domain.Models.CasUser>, ICasUserRepository
    {
        private const string _bulkcopy_destination_tbl_name = "cas_User";
        public CasUserRepository(CASContext context) : base(context)
        {
        }

        public async Task<Domain.Models.CasUser> GetByUserId(int userId)
        {
            if (userId == default)
            {
                return default;
            }

            return await GetSingleAsync(u => u.UserId.Equals(userId));
        }
        
    }
}
