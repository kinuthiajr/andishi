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
    public class ArticleRepository : IArticleRepository
    {
        private readonly AndishiDbContext _context;
        public ArticleRepository(AndishiDbContext context)
        {
            _context = context;   
        }

        public async Task<Article> CreateArticle(Article article)
        {
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
            return article;  
        }

        public Task<bool> DeleteArticle(Guid articleid)
        {
            var article = _context.Articles.FirstOrDefault(a => a.Id == articleid);
            if (article is not null)
            {
                _context.Articles.Remove(article);
                _context.SaveChanges();
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public async Task<IEnumerable<Article>> GetAllArticles()
        {
            return await _context.Articles.ToListAsync();
        }

        public async Task<Article?> GetArticleById(Guid articleid)
        {
            return await _context.Articles.FindAsync(articleid);
        }


        public async Task<Article> UpdateArticle( Article article)
        {
            _context.Entry(article).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return article;
        }


        public async Task<bool> ArticleExists(Guid id)
        {
            var exists = await _context.Articles.AnyAsync(a => a.Id == id);
            Console.WriteLine($"Article Exists Check: ID = {id}, Exists = {exists}");
            return exists;
        }
    }
}