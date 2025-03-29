using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Core.Entities;

namespace Andishi.Application.Articles.DTOs
{
    public class UpdateArticleResponseDTO
    {
        public bool Success {get;set;}
        public string? Message {get;set;}
        public Article? Article {get;set;}
    }
}