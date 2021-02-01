using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifetimeScopesConsole.Services
{
    public class ScopedService : IScoped
    {
        public int Counter { get; set; }

        public ScopedService()
        {

        }
    }
}
