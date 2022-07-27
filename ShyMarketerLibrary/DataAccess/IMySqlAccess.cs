using ShyMarketerLibrary.Models;

namespace ShyMarketerLibrary.DataAccess
{
    public interface IMySqlAccess
    {
        string ConnectionString { get; set; }

        Task<List<T>> Fetch<T, U>(string sql, U parameters);
        public void Execute<T, U>(string sql, U parameters);
        public void Insert(Article article, string query);
        public int GetMarketingID(string query, string companySector);
        public List<string> GetMarketingSectors(string query);
        public List<int> GetMiniArticleIDs(string query, string companySector);
        
    }
}