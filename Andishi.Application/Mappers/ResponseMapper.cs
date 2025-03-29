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
        public static ResponseDTO ToResponsedto(this Response response)
        {
            return new ResponseDTO
            {
                Content = response.Content,
                ArticleId = response.ArticleId,
                CreatedAt = response.CreatedAt
            };
        }
    }
}