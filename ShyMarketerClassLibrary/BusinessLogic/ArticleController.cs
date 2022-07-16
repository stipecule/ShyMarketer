﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyMarketerClassLibrary.BusinessLogic
{
    public class ArticleController : IArticleController
    {
        private readonly IMySqlAccess _db;
        public ArticleController(IMySqlAccess db)
        {
            _db = db;
        }

        public Task<List<Article>> LoadArticle(int id)
        {
            string queryString = @"Select CompanyName,CompanySector,AboutCompanyText,CompanyLink,ArticleTitle,ArticlePunchLine,
                                   ArticleText,ArticleTargetAudience from articles where id=@ID";
            var parameters = new DynamicParameters();
            parameters.Add("@ID", id);
            return _db.Fetch<Article, dynamic>(queryString, parameters);
        }
        public void SaveArticle(Article article)
        {
            string queryString = @"insert into articles(CompanyName,CompanySector,AboutCompanyText,CompanyLink,ArticleTitle,ArticlePunchLine,ArticleText,ArticleTargetAudience) 
values(@CompanyName,@CompanySector,@AboutCompanyText,@CompanyLink,@ArticleTitle,@ArticlePunchLine,@ArticleText,@ArticleTargetAudience)";

            var parameters = new DynamicParameters();
            parameters.Add("@CompanyName", article.CompanyName);
            parameters.Add("@CompanySector", article.CompanySector);
            parameters.Add("@AboutCompanyText", article.AboutCompanyText);
            parameters.Add("@CompanyLink", article.CompanyLink);
            parameters.Add("@ArticlePunchLine", article.ArticlePunchLine);
            parameters.Add("@ArticleText", article.ArticleText);
            parameters.Add("@ArticleTargetAudience", article.ArticleTargetAudience);
            _db.Execute<Article, dynamic>(queryString, parameters);
        }


    }
}
