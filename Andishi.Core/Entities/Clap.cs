using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andishi.Core.Entities
{
    public class Clap
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public Guid ArticleId { get; set; } // Foreign key to Article
        public Article Article {get; set;} = null!; // Reps the Article obj that a Clap is related to
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}