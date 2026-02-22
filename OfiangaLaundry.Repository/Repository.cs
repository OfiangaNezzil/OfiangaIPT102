using OfiangaLaundry.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace OfiangaLaundry.Repository
{
    public class Repository : IRepository
    {
        private readonly IConfiguration _configuration;

        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<T>> GetDataAsync<T>(
            string connectionName,
            string storedProcedure,
            DynamicParameters parameters = null)
        {
            var connectionString = _configuration.GetConnectionString(connectionName);

            using var connection = new SqlConnection(connectionString);

            return await connection.QueryAsync<T>(
                storedProcedure,
                param: parameters,
                commandType: CommandType.StoredProcedure
            );
        }

        public async Task<bool> SaveDataAsync(
            string connectionName,
            string storedProcedure,
            DynamicParameters parameters = null)
        {
            var connectionString = _configuration.GetConnectionString(connectionName);

            using var connection = new SqlConnection(connectionString);

            var rowsAffected = await connection.ExecuteAsync(
                storedProcedure,
                param: parameters,
                commandType: CommandType.StoredProcedure
            );

            return rowsAffected > 0;
        }
    }
}