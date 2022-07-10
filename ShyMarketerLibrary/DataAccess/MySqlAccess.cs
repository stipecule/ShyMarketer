using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyMarketerLibrary.DataAccess
{
    public class MySqlAccess : IMySqlAccess
    {
        private readonly IConfiguration _config;
        public string ConnectionString { get; set; } = "";

        public MySqlAccess(IConfiguration config)
        {
            _config = config;
        }
        public async Task<List<T>> Fetch<T, U>(string sql, U parameters)
        {

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);
                return data.ToList();
            }
        }
    }
}
