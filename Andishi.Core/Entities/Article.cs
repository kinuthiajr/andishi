using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andishi.Core.Entities
{
    public class Article
    {
        public Guid Id { get; init; } 
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public List<Response> Responses { get; set; } = new();
        public List<Clap> Claps { get; set; } = new();
        public DateTime CreatedAt { get; set; }
        
    }
}