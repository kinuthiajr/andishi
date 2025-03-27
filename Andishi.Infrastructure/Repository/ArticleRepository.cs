using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Core.Entities;
using Andishi.Core.Interfaces;
using Andishi.Infrastructure.Data;

namespace Andishi.Infrastructure.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly AndishiDbContext _context;
        public ArticleRepository(AndishiDbContext context)
        {
            _context = context;   
        }

        public async Task<Article> CreateArticle(Article article)
        {
            throw new NotImplementedException();   
        }

        public Task<bool> DeleteArticle(Guid articleid)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Article>> GetAllArticles()
        {
            throw new NotImplementedException();
        }

        public Task<Article?> GetArticleById(Guid articleid)
        {
            throw new NotImplementedException();
        }

        public Task<Article> UpdateArticle(Guid articleid)
        {
            throw new NotImplementedException();
        }
    }
}