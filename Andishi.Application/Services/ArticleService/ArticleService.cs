using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Application.Articles.DTOs;
using Andishi.Application.Interfaces;
using Andishi.Core.Entities;
using Andishi.Core.Interfaces;

namespace Andishi.Application.Services.ArticleService
{
    public class ArticleService : IArticleService
    {

        private readonly IArticleRepository _articleRepository;
        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<Article> CreateArticleAsync(CreateArticleDTO createArticleDTO)
        {
            var newArticle = new Article
            {
                Title = createArticleDTO.Title,
                Content = createArticleDTO.Content,
                CreatedAt = DateTime.UtcNow, 
            };
            return await _articleRepository.CreateArticle(newArticle);
        }

        public Task<bool> DeleteArticleAsync(Guid id)
        {
            var deleteArticle = _articleRepository.DeleteArticle(id);
            return deleteArticle;
        }

        public async Task<IEnumerable<Article>> GetAllArticlesAsync()
        {
           return await _articleRepository.GetAllArticles();
        }

        public async Task<ArticleDTO?> GetArticleByIdAsync(Guid id)
        {
            var article = await _articleRepository.GetArticleById(id);
            if (article == null)
            {
                return null;
            }

            return new ArticleDTO
            {
                Id = article.Id,
                Title = article.Title,
                Content = article.Content,

                ResponseCount = article.Responses.Count,
                ClapCount = article.Claps.Count,
            };
        }

        public async Task<Article> UpdateArticleAsync(Guid id, UpdateArticleDTO updateArticleDTO)
        {
            var article = await _articleRepository.GetArticleById(id);
            if (article != null)
            {
                article.Title = updateArticleDTO.Title ?? article.Title;
            article.Content = updateArticleDTO.Content ?? article.Content;
      
            await _articleRepository.UpdateArticle(article);
            return article;
            }

            return null;

           
        }

        
    }
}