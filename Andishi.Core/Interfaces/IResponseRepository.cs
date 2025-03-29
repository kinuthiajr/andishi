using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Core.Entities;

namespace Andishi.Core.Interfaces
{
    public interface IResponseRepository
    {
        Task<IEnumerable<Response?>> GetAllResponses();
        Task<Response?> GetResponseById(Guid id);
        Task<Response> CreateResponse(Response response);
        Task<Response> UpdateResponse(Guid id, Response response); 
        Task<bool> DeleteResponse(Guid id);

    }
}