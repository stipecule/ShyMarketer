namespace ShyMarketerLibraries.BusinessLogic
{
    public interface IArticleController
    {
        System.Threading.Tasks.Task<System.Collections.Generic.List<Article>> LoadArticle(int id);
    }
}