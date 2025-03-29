using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andishi.Application.DTOs.Response
{
    public class PostResponseDTO
    {
         public string Content { get; set; } = string.Empty;
         public Guid ArticleId { get; set; } // Foreign key to Article
         public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}