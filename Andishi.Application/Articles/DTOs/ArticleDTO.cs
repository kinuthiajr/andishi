using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andishi.Application.Articles.DTOs
{
    public class ArticleDTO
    {
        public Guid Id { get; init; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty; 
        public DateTime CreatedAt { get; init; }
        public int ResponseCount { get; init; }
        public int ClapCount { get; init; }
    }
}