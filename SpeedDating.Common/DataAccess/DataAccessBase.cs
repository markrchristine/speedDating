using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace SpeedDating.Common.DataAccess
{
    public abstract class DataAccessBase : IDisposable
    {
        private readonly string _connectionString;

        protected DataAccessBase(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlConnection _connection;
        protected SqlConnection Connection => _connection ?? (_connection = new SqlConnection(_connectionString));

        protected IEnumerable<T> Query<T>(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Connection.Query<T>(sql, param, transaction, buffered, commandTimeout, commandType);
        }

        protected T QueryFirst<T>(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Connection.QueryFirst<T>(sql, param, transaction, commandTimeout, commandType);
        }


        protected Task<IEnumerable<T>> QueryAsync<T>(string sql, object param=null, IDbTransaction transaction=null,int? commandTimeout=null, CommandType? commandType=null)
        {
            return Connection.QueryAsync<T>(sql, param, transaction, commandTimeout, commandType);
        }

        protected Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Connection.QueryFirstOrDefaultAsync<T>(sql, param, transaction, commandTimeout, commandType);
        }

        protected int Execute(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Connection.Execute(sql, param, transaction, commandTimeout, commandType);
        }

        protected Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Connection.ExecuteAsync(sql, param, transaction, commandTimeout, commandType);

        }

        protected T ExecuteScalar<T>(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Connection.ExecuteScalar<T>(sql, param, transaction, commandTimeout, commandType);
        }

        protected Task<T> ExecuteScalarAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Connection.ExecuteScalarAsync<T>(sql, param, transaction, commandTimeout, commandType);

        }


        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}
