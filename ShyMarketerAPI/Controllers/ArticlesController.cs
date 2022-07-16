using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShyMarketerLibrary.BusinessLogic;
using ShyMarketerLibrary.Models;

namespace ShyMarketerAPI.Controllers
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
    }
}
