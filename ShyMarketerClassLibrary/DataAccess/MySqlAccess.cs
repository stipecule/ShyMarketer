using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyMarketerClassLibrary.DataAccess
{
    private readonly IConfiguration _config;
    public string ConnectionString { get; set; } = "Server=635yhnodd4t4.eu-central-2.psdb.cloud;Database=shymarketer;user=vbrolhx6s6bu;password=pscale_pw_dlrE97Q11Os0oC4Jspq1RK8bF7Qw659FvLymZJ3zCHY;SslMode=VerifyFull;";

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
    public void Execute<T, U>(string sql, U parameters)
    {

        using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
        {
            var data = connection.QueryAsync<T>(sql, parameters);
        }
    }
}
}
