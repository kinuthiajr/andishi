using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Application.DTOs.Response;
using Andishi.Core.Entities;
using Andishi.Core.Interfaces;

namespace Andishi.Application.Services.ResponseService
{
    public class ResponseService : IResponseRepository
    {
        private readonly IResponseRepository _responseRepository;

        public ResponseService(IResponseRepository responseRepository)
        {
            _responseRepository = responseRepository;
        }

        // public async Task<Response> CreateResponse(PostResponseDTO response)
        // {
        //     var newResponse = new Response
        //     {
        //         Content = response.Content,
        //         CreatedAt = response.CreatedAt,
        //         ArticleId = response.ArticleId
        //     };
        //     return await _responseRepository.CreateResponse(newResponse);
        // }

        public async Task<Response?> GetResponseById(Guid id)
        {
            return await _responseRepository.GetResponseById(id);
        }

        public async Task<IEnumerable<Response?>> GetAllResponses()
        {
            return await _responseRepository.GetAllResponses();
        }

        // public async Task<Response> UpdateResponse(Guid id, UpdateResponseDTO response)
        // {
        //     var existingResponse = await _responseRepository.GetResponseById(id);
        //     if (existingResponse != null)
        //     {
        //         existingResponse.Content = response.Content;
        //         existingResponse.CreatedAt = response.CreatedAt;
        //         existingResponse.ArticleId = response.ArticleId;
        //     }
        //     return await _responseRepository.UpdateResponse(existingResponse);
        // }


        public async Task<bool> DeleteResponse(Guid id)
        {
            var deleteResponse = await _responseRepository.GetResponseById(id);
            if (deleteResponse != null)
            {
                return await _responseRepository.DeleteResponse(id);
            }
            return false;
        }

        public async Task<Response> CreateResponse(Response response)
        {
            var newResponse = new Response
            {
                Content = response.Content,
                CreatedAt = response.CreatedAt,
                ArticleId = response.ArticleId
            };
            return await _responseRepository.CreateResponse(newResponse);
        }

        public async Task<Response> UpdateResponse(Guid id, Response response)
        {
            var existingResponse = await _responseRepository.GetResponseById(id);
            if (existingResponse != null)
            {
                existingResponse.Content = response.Content;
                existingResponse.CreatedAt = response.CreatedAt;
                existingResponse.ArticleId = response.ArticleId;
            }
            return await _responseRepository.UpdateResponse(id,existingResponse);
        }
    }
}