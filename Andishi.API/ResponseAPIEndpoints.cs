using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andishi.API
{
    public class ResponseAPIEndpoints
    {
        private const string ApiBase = "api";

        public static class Response
        {
            public const string Base = $"{ApiBase}/response";
            public const string Create = $"{Base}/create/{{articleid:guid}}";
            public const string GetById = $"{Base}/{{id:guid}}";
            public const string GetAll = Base;
            public const string Update = $"{Base}/{{id:guid}}";
            public const string Delete = $"{Base}/{{id:guid}}";
        }
    }
}