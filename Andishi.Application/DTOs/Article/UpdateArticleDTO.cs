using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andishi.Application.Articles.DTOs
{
    public class UpdateArticleDTO
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}