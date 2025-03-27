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
        Task<Article?> GetArticleByIdAsync(Guid id);
        Task<IEnumerable<Article>> GetAllArticlesAsync();
        Task UpdateArticleAsync(Guid id, UpdateArticleDTO updateArticleDTO);
        Task DeleteArticleAsync(Guid id);
    }
}