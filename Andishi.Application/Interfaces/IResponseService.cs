using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Application.DTOs.Response;
using Andishi.Core.Entities;

namespace Andishi.Application.Interfaces
{
    public interface IResponseService
    {
        Task<IEnumerable<Response>> GetAllResponsesAsync();
        Task<ResponseDTO?> GetResponseByIdAsync(Guid id);
        Task<Response> CreateResponseAsync(Response response);
        Task<Response> UpdateResponseAsync(Guid id, UpdateResponseDTO updateResponseDTO);
        Task<bool> DeleteResponseAsync(Guid id);
    }
}