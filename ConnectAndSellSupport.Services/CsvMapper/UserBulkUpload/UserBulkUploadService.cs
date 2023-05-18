using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Domain.Models.Custom.User;
using ConnectAndSellSupport.Domain.ViewModels;
using ConnectAndSellSupport.Repository.Contracts;
using ConnectAndSellSupport.Repository.Contracts.CasUser;
using ConnectAndSellSupport.Repository.Contracts.TCompany;
using ConnectAndSellSupport.Repository.Contracts.TUser;
using ConnectAndSellSupport.Repository.Factory;
using ConnectAndSellSupport.Repository.UserBulkUpload.PasswordUtility;
using ConnectAndSellSupport.Services.Extensions;
using ConnectAndSellSupport.Services.Helpers.PhoneSys;
using ConnectAndSellSupport.Services.Models.Response.User;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Services.CsvMapper
{
    public class UserBulkUploadService : IUserBulkUploadService
    {
        private readonly ITUserRepository _tUserRepository;
        private readonly ICSVService _csvService;
        private readonly ITCompanyRepository _tCompanyRepository;
        private readonly SQLBulkFactory _sqlBulkFactory;
        private const string _default_user = "SupportGenerated";
        private const string _default_country = "United States";
        private const string _default_category = "category";
        private const string _default_varname = "agents";
        private const string _default_filename = "agents.conf";
        private const string _default_locationcode = "Nirvana";
        private const string _default_tUser_tableName = "t_User";
        private const string _default_casUser_tableName = "cas_User";
        private long unixTime = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();

        public UserBulkUploadService(ICSVService csvService, ITUserRepository tUserRepository, ITCompanyRepository tCompanyRepository, SQLBulkFactory sqlBulkFactory)
        {
            _csvService = csvService;
            _tUserRepository = tUserRepository;
            _sqlBulkFactory = sqlBulkFactory;
            _tCompanyRepository = tCompanyRepository;
        }

        public (bool, List<UserUploadError>) BulkSaveUser(IFormFileCollection file, int companyId, Roles[] roleId)
        {
            var company = _tCompanyRepository.GetSingleAsync(x => x.Id == companyId).Result;

            List<UserBulkUploadPayload> csvUsers = _csvService.ReadCSV<UserBulkUploadPayload>(file[0].OpenReadStream()).ToList();

            List<TUser> tUsers = GetTUsers(csvUsers, company, roleId);

            List<UserUploadError> CSVValidation = ValidateTUser(tUsers, company, csvUsers);
            if (!CSVValidation.Any(x => x.Error != String.Empty))
            {
                try
                {
                    using (var _sqlBulkOperation = _sqlBulkFactory.BeginOperation())
                    {
                        _sqlBulkOperation.BulkInsert(tUsers.ToDataTable(_default_tUser_tableName));
                        List<string> EmailIds = tUsers.Select(x => x.LoginEmailId).ToList();
                        string defaultPassword = unixTime.ToString();
                        List<int> UserIds = GetNewlyCreatedUsers();
                        List<CasUser> casModel = new List<CasUser>();
                        for (int i = 0; i < UserIds.Count; ++i)
                        {
                            casModel.Add(new CasUser()
                            {
                                UserId = UserIds[i],
                                CreateDate = DateTime.UtcNow,
                                FailedPasswordAttempts = 0,
                                CreateUser = "AdminCenerated",
                                ModUser = "AdminGenerated",
                                Password = PasswordHash.CreateHash(csvUsers[i].Password),
                                IsTourCompleted = false,
                                IsApproved = true,
                                IsPasswordReset = true,
                                ModDate = DateTime.Now
                            });
                        }
                        _sqlBulkOperation.BulkInsert(casModel.ToDataTable(_default_casUser_tableName));
                        _sqlBulkOperation.Complete();
                    }
                    return (true, null);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            else
            {
                return (false, CSVValidation);
            }

            //return this._userBulkUploadRepository.BulkSaveUser(model);
        }


        private List<TUser> GetTUsers(List<UserBulkUploadPayload> users, TCompany company, Roles[] roleId)
        {
            List<TUser> model = new List<TUser>();

            var roles = GetPermittedRolesValue(roleId);

            for (int i = 0; i < users.Count; ++i)
            {
                model.Add(new TUser()
                {
                    CatMetric = 1,
                    VarMetric = 100,
                    Commented = 0,
                    Filename = _default_filename,
                    Category = _default_category,
                    VarName = _default_varname,
                    LoginPw = unixTime.ToString(),
                    Country = _default_country,
                    Score = 0,
                    UserName = users[i].Name,
                    LoginId = users[i].Name.ToLower(),
                    LoginEmailId = users[i].Email,
                    CompanyName = company.CompanyName,
                    CompanyId = company.Id,
                    VarVal = String.Format("{0},{1},{2}", PhoneSys.KeypadEquiv(users[i].Name), unixTime.ToString(), users[i].Name.ToLower()),
                    CreateDate = DateTime.UtcNow,
                    CreateUser = unixTime.ToString(),
                    ModDate = DateTime.UtcNow,
                    ModUser = unixTime.ToString(),
                    PermittedRoles = roles,
                    CallbackNumber = "+10",
                    VoicemailLength = 0,
                    DotNetVersion = String.Empty,
                    Priority = 0,
                    Sla = 0,
                    LanguageSkills = 1,
                    LocationCode = _default_locationcode,
                    HourlyRate = 0,
                    InviteAlertMinutes = 60,
                    DomainId = String.Empty,
                    DomainLoginRequired = false,
                    RequiresDispositions = true,
                    IsLightningOnly = false,
                    SortOrder = 0,
                    IsDeleted = false,
                    ExistingUserActivationStatus = 0,

                    //Empty Values
                    Identifier = users[i].Name,
                    Address1 = String.Empty,
                    Address2 = String.Empty,
                    City = String.Empty,
                    State = String.Empty,
                    Zip = String.Empty,
                    Tel1 = String.Empty,
                    Ext1 = String.Empty,
                    Tel2 = String.Empty,
                    Ext2 = String.Empty,
                    FaxExt = String.Empty,
                    Email1 = String.Empty,
                    Background = String.Empty,
                    Email2 = String.Empty,
                    AccountType = String.Empty,
                    Colvpriority = 0,
                    Colvsla = 0
                });
            }
            return model;
        }

        private List<int> GetNewlyCreatedUsers()
        {
            var Ids = _tUserRepository.GetMultiAsync(u => u.CreateUser == Convert.ToString(unixTime)).Result;
            return Ids.Select(x => x.Id).ToList();
        }

        private List<UserUploadError> ValidateTUser(List<TUser> users, TCompany company, List<UserBulkUploadPayload> csvUsers)
        {
            List<UserUploadError> result = new List<UserUploadError>();
            var usernames = csvUsers.Select(x => x.Name.ToLower()).ToArray();
            var data = _tUserRepository.GetByCompanyId(company.Id).Result;
            var duplicatesInCSV = csvUsers
                                    .GroupBy(user => user.Name.ToLower())
                                    .Where(group => group.Count() > 1)
                                    .Select(group => new { Name = group.Key, Count = group.Count() });


            foreach (var record in csvUsers)
            {
                string errorStr = string.Empty;
                if (HasSpecialCharacters(record.Name))
                {
                    errorStr += "LoginID should not contain any special characters, ";
                }
                if (data.Any(x => x.LoginId.ToLower() == record.Name.ToLower()))
                {
                    errorStr += "LoginID Exists in DB, ";
                }
                if (duplicatesInCSV.Any(x => x.Name.ToLower() == record.Name.ToLower()))
                {
                    errorStr += "Duplicate Name found in CSV, ";
                }
                if (!IsValidEmail(record.Email))
                {
                    errorStr += "Email ID is invalid, ";
                }

                if (!string.IsNullOrEmpty(errorStr))
                    errorStr = errorStr.Substring(0, errorStr.Length - 2);

                result.Add(new UserUploadError()
                {
                    UserName = record.Name,
                    Password = record.Password,
                    EmailId = record.Email,
                    Error = errorStr
                });
            }
            return result;
        }

        private int GetPermittedRolesValue(Roles[] roles)
        {
            int PermittedRoles = 0;
            foreach (var role in roles)
            {
                PermittedRoles |= (int)role;
            }
            return PermittedRoles;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        private bool HasSpecialCharacters(string input)
        {
            string pattern = @"[^a-zA-Z0-9]"; // Matches any character that is NOT a letter, a number
            return Regex.IsMatch(input, pattern);
        }

    }
}
