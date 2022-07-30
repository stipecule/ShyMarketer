using Dapper;
using ShyMarketerLibrary.DataAccess;
using ShyMarketerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShyMarketerLibrary.DataAccess;
using Microsoft.Extensions.Configuration;

namespace ShyMarketerLibrary.BusinessLogic
{
    public class ArticleController : IArticleController
    {
        private readonly IMySqlAccess _db;
        private readonly IConfiguration _config;
        private string ConnectionString { get; set; }
        public ArticleController(IMySqlAccess db, IConfiguration config)
        {
            _config = config;
            ConnectionString = _config.GetConnectionString("MySql");
            _db = db;
        }

        public  Task<List<Article>> LoadArticle(int id)
        {
            string queryString = @"Select CompanyName,CompanySector,AboutCompanyText,CompanyLink,ArticleTitle,ArticlePunchLine,
                                   ArticleText,ArticleTargetAudience,ArticleImage from articles where id=@ID";
            var parameters = new DynamicParameters();
            parameters.Add("@ID", id);
            return _db.Fetch<Article, dynamic>(queryString, parameters);
        }

        public void SaveArticle(Article article)
        {
            string queryString = @"insert into articles(CompanyName,CompanySector,AboutCompanyText,CompanyLink,ArticleTitle,ArticlePunchLine,ArticleText,ArticleTargetAudience,ArticleImage) 
values(@CompanyName,@CompanySector,@AboutCompanyText,@CompanyLink,@ArticleTitle,@ArticlePunchLine,@ArticleText,@ArticleTargetAudience,@ArticleImage);";

            _db.Insert(article, queryString);
        }
        public int LoadArticleId(string CompanySector)
        {
            string queryString = @"select id from articles where CompanySector = @CompanySector order by LastSeen asc limit 1;";
            //var parameters = new DynamicParameters();
            //parameters.Add("@CompanySector", CompanySector);
            return _db.GetMarketingID(queryString, CompanySector);
        }
        public  List<string> LoadArticleSectors()
        {
            string queryString = @"select distinct ArticleTargetAudience from articles;";
            //var parameters = new DynamicParameters();
            //parameters.Add("@CompanySector", CompanySector);
            return _db.GetMarketingSectors(queryString);
        }
        public List<int> GetMiniArticleIDs(string CompanySector)
        {
            string queryString = @"select id from articles where ArticleTargetAudience=@CompanySector;";
            //var parameters = new DynamicParameters();
            //parameters.Add("@CompanySector", CompanySector);
            return _db.GetMiniArticleIDs(queryString, CompanySector);
        }
        public void UpdateLastSeen(int id)
        {
            string queryString = @"update articles set LastSeen=NOW() where id=@id;";

        var parameters = new { id = id };
            //parameters.Add("@CompanySector", article.CompanySector);
            //parameters.Add("@AboutCompanyText", article.AboutCompanyText);
            //parameters.Add("@CompanyLink", article.CompanyLink);
            //parameters.Add("@ArticlePunchLine", article.ArticlePunchLine);
            //parameters.Add("@ArticleText", article.ArticleTitle);
            //parameters.Add("@ArticleText", article.ArticleText);
            //parameters.Add("@ArticleTargetAudience", article.ArticleTargetAudience);
            //_db.Execute<Article, dynamic>(queryString, parameters);
            using (var con = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                con.Query(queryString,parameters);
            }
           
        }

    }
}
