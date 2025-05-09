using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Application.Articles.DTOs;
using Andishi.Application.Interfaces;
using Andishi.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Andishi.API.Controllers
{
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet(APIEndpoints.Articles.GetAll)]
        public async Task<ActionResult<IEnumerable<Article>>> GetAllArticles()
        {
            var articles = await _articleService.GetAllArticlesAsync();
            return Ok(articles);
        }


        [HttpPost(APIEndpoints.Articles.Create)]
        public async Task<ActionResult<Article>> CreateArticle([FromBody]CreateArticleDTO createArticleDTO)
        {
            var newArticle = await _articleService.CreateArticleAsync(createArticleDTO);
            return CreatedAtAction(nameof(GetArticle), new{id = newArticle.Id}, newArticle);
        }

        [HttpGet(APIEndpoints.Articles.Get)]
        public async Task<ActionResult<ArticleDTO>> GetArticle([FromRoute]Guid id)
        {
            var article = await _articleService.GetArticleByIdAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }

        [HttpPut(APIEndpoints.Articles.Update)]
        public async Task<ActionResult<UpdateArticleResponseDTO>> UpdateArticle([FromRoute] Guid id,[FromBody]UpdateArticleDTO updateArticleDTO)
        {
            var updateArticle = await _articleService.UpdateArticleAsync(id, updateArticleDTO);
            if (updateArticle == null)
            {
                return NotFound();
            }
            return Ok(updateArticle);
        }

        [HttpDelete(APIEndpoints.Articles.Delete)]
        public async Task<ActionResult> DeleteArticle([FromRoute] Guid id)
        {
            var deleteArticle = await _articleService.DeleteArticleAsync(id);
            if (deleteArticle == null)
            {
                return NotFound();
            }
            return Ok(deleteArticle);
        }
    }
}