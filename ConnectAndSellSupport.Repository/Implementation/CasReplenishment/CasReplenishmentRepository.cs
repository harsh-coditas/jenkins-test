using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.CasContactUserReplenishment;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConnectAndSellSupport.Repository.Implementation.CasReplenishment
{
    public class CasReplenishmentRepository : Repository<CasContactUserReplenishment>, ICasReplenishmentRepository
    {
        public CasReplenishmentRepository(CASContext context) : base(context)
        {
        }
        public async Task<IList<CasContactUserReplenishment>> GetReplenishmentEntity(string companyName, List<string> lstUserNames, DateTime fromDate, DateTime toDate)
        {   
            List<CasContactUserReplenishment> lstDownloadDataList = new List<CasContactUserReplenishment>();
            List<CasContactUserReplenishment> replenishmentData = new List<CasContactUserReplenishment>();
            foreach (var username in lstUserNames)
            {
                bool copyflag = false;
                replenishmentData = (from cc in ((CASContext)_context).CasContacts
                                     join u in ((CASContext)_context).TUsers on cc.UserId equals u.Id
                                     where u.CompanyName == companyName && u.UserName == username
                                           && cc.CreatedDate > fromDate && cc.CreatedDate < toDate
                                     select new CasContactUserReplenishment()
                                     {
                                         ClientName = u.CompanyName,
                                         CreatedDate = u.CreateDate,
                                         UserName = u.UserName,
                                         FirstName = cc.FirstName,
                                         LastName = cc.LastName,
                                         ContactCompanyName = cc.CompanyName,
                                         Title = cc.Title,
                                         Phone1 = cc.Phone1,
                                         Phone2 = cc.Phone2,
                                         Email = cc.Email,
                                         TimeZone = cc.TimeZone,
                                         Country = cc.ContactCountry,
                                         IsReferral =
                                         (
                                          cc.ReferralId == null ? "No" : "Yes"
                                         ),
                                         CrmUrl = cc.CrmUrl,
                                         Active = (bool)cc.Active,
                                         LastModifiedDate = (DateTime)cc.LastModifiedDate
                                     }).Cast<CasContactUserReplenishment>().ToList();

                if (lstDownloadDataList.Count <= 0)
                {
                    copyflag = true;
                    lstDownloadDataList = replenishmentData;
                }
                if (replenishmentData.Count > 0 && !copyflag)
                    lstDownloadDataList = lstDownloadDataList.Concat(replenishmentData).ToList();
            }

            return await Task.FromResult((IList<CasContactUserReplenishment>)lstDownloadDataList);
        }
    }
}
