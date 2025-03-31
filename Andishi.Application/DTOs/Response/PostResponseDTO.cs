using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Core.Entities;

namespace Andishi.Application.DTOs.Response
{
    public class PostResponseDTO
    {
        public Guid Id {get; init;}
        public Guid ArticleId{get; init;}
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}