using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Core.Entities;
using Andishi.Core.Interfaces;
using Andishi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Andishi.Infrastructure.Repository
{
    public class ResponseRepository : IResponseRepository
    {
        private readonly AndishiDbContext _context;

        public ResponseRepository(AndishiDbContext context)
        {
            _context = context;
        }

        public async Task<Response> CreateResponse(Response response)
        {
            _context.Responses.Add(response);
            await _context.SaveChangesAsync();
            return response;

        }

        public Task<bool> DeleteResponse(Guid id)
        {
            var deleteResponse = _context.Responses.FirstOrDefault(a => a.Id == id);
            if(deleteResponse != null)
            {
                _context.Responses.Remove(deleteResponse);
                _context.SaveChanges();
                return Task.FromResult(false);
            }

            return Task.FromResult(true);
        }

        public async Task<IEnumerable<Response?>> GetAllResponses()
        {
            return await _context.Responses.ToListAsync();
        }

        public async Task<Response?> GetResponseById(Guid id)
        {
            return await _context.Responses.FirstOrDefaultAsync(a => a.Id == id);
           
        }

        public Task<Response> UpdateResponse(Guid id, Response response)
        {
            var updateResponse = _context.Responses.FirstOrDefault(a => a.Id == id);
            if(updateResponse != null)
            {
                updateResponse.Content = response.Content;
                updateResponse.CreatedAt = response.CreatedAt;
                updateResponse.ArticleId = response.ArticleId;
                _context.SaveChanges();
                return Task.FromResult(updateResponse);
            }
            return Task.FromResult(updateResponse);
        }
    }
}