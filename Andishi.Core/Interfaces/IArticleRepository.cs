using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Core.Entities;

namespace Andishi.Core.Interfaces
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetAllArticles();
        Task<Article?> GetArticleById(Guid articleid);
        Task<Article> CreateArticle(Article article);
        Task<Article> UpdateArticle( Article article);
        Task<bool> DeleteArticle(Guid articleid);
        Task<bool> ArticleExists(Guid id);
    }

}