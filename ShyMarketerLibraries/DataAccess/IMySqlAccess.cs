using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShyMarketerLibraries.DataAccess
{
    public interface IMySqlAccess
    {
        string ConnectionString { get; set; }

        Task<List<T>> Fetch<T, U>(string sql, U parameters);
    }
}