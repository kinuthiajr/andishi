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
    public class ClapRepository : IClapRepository
    {
        private readonly AndishiDbContext _context;

        public ClapRepository(AndishiDbContext context)
        {
            _context = context;
        }

        public async Task<Article> ArticleClap(Guid articleId)
        {
            var article = await _context.Articles
            .Include(a => a.Claps)
            .FirstOrDefaultAsync(a => a.Id == articleId);

            if (article == null) return null;

            var newClap = new Clap
            {
                ArticleId = articleId,
                CreatedAt = DateTime.Now
            };

            article.Claps.Add(newClap);
            await _context.SaveChangesAsync();
            return article;
        }

    }
}