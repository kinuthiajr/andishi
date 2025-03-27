using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andishi.Core.Entities
{
    public class Response
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public string Content { get; set; } = string.Empty;
        public Guid ArticleId { get; set; } // Foreign key to Article
        public Article Article {get; set;} = null!; // Reps the article obj that a Response is related to
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}