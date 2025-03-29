using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andishi.Application.DTOs.Response
{
    public class UpdateResponseDTO
    {
        public string Content { get; set; } = string.Empty;
        public Guid ArticleId { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}