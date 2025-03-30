using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Application.DTOs.Response;
using Andishi.Application.Interfaces;
using Andishi.Core.Entities;
using Andishi.Core.Interfaces;

namespace Andishi.Application.Services.ResponseService
{
    public class ResponseService : IResponseService    
    {
        private readonly IResponseRepository _responseRepo;

        public ResponseService(IResponseRepository responseRepo)
        {
            _responseRepo = responseRepo;
        }

        public async Task<IEnumerable<Response>> GetAllResponsesAsync()
        {
            return await _responseRepo.GetAllResponses();
        }

        public async Task<ResponseDTO?> GetResponseByIdAsync(Guid id)
        {
            var getResponse = await _responseRepo.GetResponseById(id);
            if (getResponse == null)
            {
                return null;
            }
            return new ResponseDTO
            {
                Content = getResponse.Content,
                ArticleId = getResponse.ArticleId,
                CreatedAt = getResponse.CreatedAt
            };
            
        }

        public async Task<Response> CreateResponseAsync(PostResponseDTO postResponseDTO)
        {
            var newResponse = new Response
            {
                Content = postResponseDTO.Content,
                ArticleId = postResponseDTO.ArticleId,
                CreatedAt = DateTime.UtcNow
            }; 
            return await _responseRepo.CreateResponse(newResponse);
        }

        public async Task<Response> UpdateResponseAsync(Guid id, UpdateResponseDTO updateResponseDTO)
        {
             var getResponse = await _responseRepo.GetResponseById(id);
             if (getResponse != null)
             {
                getResponse.Content = updateResponseDTO.Content;
                getResponse.ArticleId = updateResponseDTO.ArticleId;
                getResponse.CreatedAt = DateTime.UtcNow;

                await _responseRepo.UpdateResponse(id,getResponse);
                return getResponse;
             }

             return null;

             
        }

        public Task<bool> DeleteResponseAsync(Guid id)
        {
            var deleteResponse = _responseRepo.DeleteResponse(id);
            return deleteResponse;
        }
    }
}