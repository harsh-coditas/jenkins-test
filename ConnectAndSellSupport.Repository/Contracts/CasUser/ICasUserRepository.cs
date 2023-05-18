using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.CasUser
{
    public interface ICasUserRepository : IRepository<Domain.Models.CasUser>
    {
        Task<Domain.Models.CasUser> GetByUserId(int id);
    }
}
