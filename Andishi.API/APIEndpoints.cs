using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andishi.API
{
    public class APIEndpoints
    {
        private const string ApiBase = "api";
        public static class Articles
        {
            public const string Base = $"{ApiBase}/articles";
            public const string Create = $"{Base}/articles";
            public const string Get = $"{Base}/{{id:guid}}";
            public const string GetAll = Base;
            public const string Update = $"{Base}/{{id:guid}}";
            public const string Delete = $"{Base}/{{id:guid}}";
        }
    }
}