using ConnectAndSellSupport.API.Configuration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectAndSellSupport.API.Configuration
{
    public class ConnectionStringBuilder
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        private readonly List<DBSetting> _dbConfiguration;
        private readonly List<ReplicaDBSetting> _replicaDbConfiguration;
        public ConnectionStringBuilder(IHttpContextAccessor httpContextAccessor, IConfiguration configuration, IOptions<List<DBSetting>> dbSettings, IOptions<List<ReplicaDBSetting>> replicaDbSettings)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _dbConfiguration = dbSettings.Value;
            _replicaDbConfiguration = replicaDbSettings.Value;
        }

        public string GetConnectionString()
        {
            var dbNameHeader = _httpContextAccessor.HttpContext?.Request.Headers["envName"];
            string connStringTemplate = _configuration.GetConnectionString("CASDBConnection");
            var envSetting = _dbConfiguration
                .Where(x => x.Name.Equals(dbNameHeader.ToString(), StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

            if (envSetting == null)
            {
                throw new ArgumentOutOfRangeException("dbName");
            }

            return connStringTemplate.Replace("{dataSourceName}", envSetting.DataSourceName)
                .Replace("{dbName}", envSetting.DbName)
                .Replace("{userName}", envSetting.Username)
                .Replace("{password}", envSetting.Password);
        }

        public string GetReplicaConnectionString()
        {
            var dbNameHeader = _httpContextAccessor.HttpContext?.Request.Headers["envName"];
            string connStringTemplate = _configuration.GetConnectionString("CASDBConnection");
            var envSetting = _replicaDbConfiguration
                .Where(x => x.Name.Equals(dbNameHeader.ToString(), StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

            if (envSetting == null)
            {
                throw new ArgumentOutOfRangeException("dbName");
            }

            return connStringTemplate.Replace("{dataSourceName}", envSetting.DataSourceName)
                .Replace("{dbName}", envSetting.DbName)
                .Replace("{userName}", envSetting.Username)
                .Replace("{password}", envSetting.Password);
        }
    }
}
