using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShyMarketerLibrary.BusinessLogic;
using ShyMarketerLibrary.Models;

namespace ShyMarketerServer
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleController _db;
        public ArticlesController(IArticleController db)
        {
            _db = db;
        }
        [HttpPost]
        public Article PostArticle(Article article)
        {

            _db.SaveArticle(article);
            return article;
        }

        [HttpPost("{CompanySector}")]
        public int GetArticleToDisplay(string CompanySector)
        {
            Article article = new Article();
            article.id = _db.LoadArticleId(CompanySector);
            return article.id;
        }


    }
}
