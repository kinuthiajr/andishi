using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Andishi.Core.Options
{
    public class ConnectionStringOptions
    {
        public const string SectionName = "ConnectionStrings"; 
        public string dbString {get;set;} = null!; 
    }
}