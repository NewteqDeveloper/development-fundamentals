using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifetimeScopesConsole.Services
{
    public class TransientService : ITransient
    {
        public int Counter { get; set; }

        public TransientService()
        {

        }
    }
}
