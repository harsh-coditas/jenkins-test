using ConnectAndSellSupport.Repository.Models;
using ConnectAndSellSupport.Repository.UserBulkUpload.PasswordUtility;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastMember;
using System.Data;
using System.Reflection;
using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts.TUser;

namespace ConnectAndSellSupport.Repository.UserBulkUpload
{
    public class UserBulkUploadRepository : IUserBulkUploadRepository
    {
        private readonly IConfiguration _config;
        private readonly ITUserRepository _iTUserRepository;
        public UserBulkUploadRepository(IConfiguration config, ITUserRepository iTUserRepository)
        {
            _config = config;
            _iTUserRepository = iTUserRepository;
        }
        public bool BulkSaveUser(List<UserBulkUploadDBModelTCas> model)
         {
            try
            {
                //var listCols = new List<string>() { "UserName", "LoginEmailId", "CompanyName", "CompanyId", "PermittedRoles" };
                DataTable tUserTable = ToDataTable(model);
                DataView view = new DataView(tUserTable);
                DataTable table1 = view.ToTable(false);
                string connectionString = _config["ConnectionStrings:CASDBBulkUploadConnection"];
                
                //foreach (var user in model)
                //{
                //    user.PasswordHash = PasswordHash.CreateHash(user.LoginPW);
                //}
                
                using (var sqlCopy = new SqlBulkCopy(connectionString))
                {
                    sqlCopy.DestinationTableName = "[t_User]";
                    sqlCopy.BatchSize = 500;
                    sqlCopy.WriteToServer(table1);
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool BulkUploadCasUser(List<UserBulkUploadDBModelCUser> casModel)
        {
            try
            {
                DataTable casUserTable = ToDataTable(casModel);
                DataView view = new DataView(casUserTable);
                DataTable table1 = view.ToTable(false);
                string connectionString = _config["ConnectionStrings:CASDBBulkUploadConnection"];

                using (var sqlCopy = new SqlBulkCopy(connectionString))
                {
                    sqlCopy.DestinationTableName = "[cas_User]";
                    sqlCopy.BatchSize = 500;
                    sqlCopy.WriteToServer(table1);
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public async Task<IEnumerable<TUser>> BulkGetTUserId(List<string> EmailIds, string Password, long unixTime)
        {
            try
            {
                var users = await _iTUserRepository.GetIdsBulkUpload(EmailIds, Password, unixTime);
                return users;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
