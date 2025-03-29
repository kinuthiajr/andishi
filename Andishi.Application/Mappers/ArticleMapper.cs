using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Application.Articles.DTOs;
using Andishi.Core.Entities;

namespace Andishi.Application.Mappers
{
    public static class ArticleMapper
    {
        public static UpdateArticleDTO ToArticleDTO(this Article article)
        {
            return new UpdateArticleDTO
            {
               
                Title = article.Title,
                Content = article.Content
            };
        }
    }
}