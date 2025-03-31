using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Application.Articles.DTOs;
using Andishi.Core.Entities;

namespace Andishi.Application.Interfaces
{
    public interface IArticleService
    {
        Task<Article> CreateArticleAsync(CreateArticleDTO createArticleDTO);
        Task<ArticleDTO?> GetArticleByIdAsync(Guid id);
        Task<IEnumerable<Article>> GetAllArticlesAsync();
        Task <Article> UpdateArticleAsync(Guid id,UpdateArticleDTO updateArticleDTO);
        Task <bool> DeleteArticleAsync(Guid id);
        Task <bool> ArticleExistsAsync(Guid id);
    }
}