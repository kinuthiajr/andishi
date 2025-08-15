using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Core.Entities;

namespace Andishi.Core.Interfaces
{
    public interface IClapRepository
    {
        Task<Article> ArticleClap(Guid articleId);
    }
}