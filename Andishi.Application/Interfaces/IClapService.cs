using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Andishi.Core.Entities;

namespace Andishi.Application.Interfaces
{
    public interface IClapService
    {
        public Task<bool> ClapArticle(Guid articleId);
    }
}