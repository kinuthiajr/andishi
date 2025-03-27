using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Andishi.Infrastructure.Data
{
    public class AndishiDbContext : DbContext
    {
        public AndishiDbContext(DbContextOptions<AndishiDbContext> options) : base(options) {}

        public required DbSet<Article> Articles { get; set; }
        public required DbSet<Response> Responses { get; set; }
        public required DbSet<Clap> Claps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Article can have many responses and claps
            // Rship for the one to many

            modelBuilder.Entity<Response>()
                .HasOne(r => r.Article)
                .WithMany(a => a.Responses)
                .HasForeignKey(r => r.ArticleId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<Clap>()
                .HasOne(r => r.Article)
                .WithMany(a => a.Claps)
                .HasForeignKey(c => c.ArticleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}