using System.Threading.Tasks;

namespace ConnectAndSellSupport.Repository.Contracts.CasNote
{
    public interface ICasNoteRepository : IRepository<Domain.Models.CasNote>
    {
        Task<Domain.Models.CasNote> GetByLeadTransitId(int leadTransitId);
    }
}
