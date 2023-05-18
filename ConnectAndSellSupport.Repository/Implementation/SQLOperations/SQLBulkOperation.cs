using ConnectAndSellSupport.Domain.Models;
using ConnectAndSellSupport.Repository.Contracts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Data;

namespace ConnectAndSellSupport.Repository.Implementation
{
    public class SQLBulkOperation : ISQLBulkOperation
    {
        private readonly CASContext _context;
        private readonly IDbContextTransaction _transaction;
        private bool IsCompleted = false;
        private bool _isDisposed = false;
        public SQLBulkOperation(CASContext context)
        {
            _context = context;
            _transaction = _context.Database.BeginTransaction();
        }
        public void BulkInsert(DataTable dt)
        {
            var dBConnection = (SqlConnection)_context.Database.GetDbConnection();
            var transaction = (SqlTransaction)_transaction.GetDbTransaction();
            using (var sqlCopy = new SqlBulkCopy(dBConnection, SqlBulkCopyOptions.Default, transaction))
            {
                sqlCopy.DestinationTableName = $"[{dt.TableName}]";
                sqlCopy.WriteToServer(dt);
            }
        }

        public void Complete()
        {
            IsCompleted = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed)
                return;

            if (disposing && _transaction != null)
            {
                if (IsCompleted)
                {
                    _transaction.Commit();
                }
                else
                {
                    _transaction.Rollback();
                }
            }
            _isDisposed = true;
        }
    }
}
