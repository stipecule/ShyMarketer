using Dapper;
using ShyMarketerLibrary.DataAccess;
using ShyMarketerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyMarketerLibrary.BusinessLogic
{
    public class ArticleController : IArticleController
    {
        private readonly IMySqlAccess _db;
        public ArticleController(IMySqlAccess db)
        {
            _db = db;
        }

        public  Task<List<Article>> LoadArticle(int id)
        {
            string queryString = @"Select CompanyName,CompanySector,AboutCompanyText,CompanyLink,ArticleTitle,ArticlePunchLine,
                                   ArticleText,ArticleTargetAudience from articles where id=@ID";
            var parameters = new DynamicParameters();
            parameters.Add("@ID", id);
            return _db.Fetch<Article, dynamic>(queryString, parameters);
        }
    }
}
