using ShyMarketerLibrary.Models;

namespace ShyMarketerLibrary.BusinessLogic
{
    public interface IArticleController
    {
        Task<List<Article>> LoadArticle(int id);
        void SaveArticle(Article article);
        public int LoadArticleId(string CompanySector);
        public List<string> LoadArticleSectors();
        public List<int> GetMiniArticleIDs(string CompanySector);
        public void UpdateLastSeen(int id);
  
    }
}