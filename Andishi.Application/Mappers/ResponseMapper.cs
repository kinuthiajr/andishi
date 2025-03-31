using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Application.DTOs.Response;
using Andishi.Core.Entities;

namespace Andishi.Application.Mappers
{
    public static class ResponseMapper
    {
        public static Response ToResponsedto(this PostResponseDTO response, Guid articleid)
        {
            return new Response
            {
                Content = response.Content,
                ArticleId = articleid,
                CreatedAt = response.CreatedAt
            };
        }

        public static PostResponseDTO ToResponseDTO(this Response response)
        {
            return new PostResponseDTO
            {
                Id = response.Id,
                Content = response.Content,
                ArticleId = response.ArticleId,
                CreatedAt = response.CreatedAt
            };
        }
    }
}