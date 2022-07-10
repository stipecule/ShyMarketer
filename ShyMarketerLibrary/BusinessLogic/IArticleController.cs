﻿using ShyMarketerLibrary.Models;

namespace ShyMarketerLibrary.BusinessLogic
{
    public interface IArticleController
    {
        Task<List<Article>> LoadArticle(int id);
    }
}