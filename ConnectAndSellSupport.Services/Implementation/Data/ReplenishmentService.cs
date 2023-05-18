using AutoMapper;
using ClosedXML.Excel;
using ConnectAndSellSupport.Repository.Contracts.CasContactUserReplenishment;
using ConnectAndSellSupport.Repository.Contracts.TCompany;
using ConnectAndSellSupport.Repository.Contracts.TUser;
using ConnectAndSellSupport.Services.Contracts.Data;
using ConnectAndSellSupport.Services.Models.Request.Data;
using ConnectAndSellSupport.Services.Models.Response.Data;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.Implementation.Data
{
    public class ReplenishmentService : IReplenishmentService
    {
        #region Private members
        private readonly ITUserRepository _tUserRepository;
        private readonly ITCompanyRepository _tCompanyRepository;
        private readonly ICasReplenishmentRepository _casReplenishmentRepository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public ReplenishmentService(
            ITUserRepository tUserRepository,
            ITCompanyRepository tCompanyRepository,
            ICasReplenishmentRepository casReplenishmentRepository,
            IMapper mapper)
        {
            _tUserRepository = tUserRepository;
            _tCompanyRepository = tCompanyRepository;
            _casReplenishmentRepository = casReplenishmentRepository;
            _mapper = mapper;
        }
        #endregion
        public async Task<ReplenishmentServiceResponse> GetReplenishmentEntity(GetReplenishmentRequest entityRequest)
        {
            if (entityRequest.CompanyName == default)
            {
                return default;
            }

            var replenishmentData = await _casReplenishmentRepository.GetReplenishmentEntity(entityRequest.CompanyName, entityRequest.UserNames, entityRequest.FromDate, entityRequest.ToDate);

            var workbook = new XLWorkbook();
            var wsDetailedData = workbook.AddWorksheet("ReplenishmentData");
            wsDetailedData.Cell(1, 1).InsertTable(replenishmentData);
            workbook.SaveAs(@"replenishmentData.xlsx");

            if (replenishmentData == null || replenishmentData.Count <= 0)
            {
                return new ReplenishmentServiceResponse
                {
                    ReplenishmentDataNotFound = true
                };
            }

            return new ReplenishmentServiceResponse
            {
                Success = true
            };

        }

    }
}
