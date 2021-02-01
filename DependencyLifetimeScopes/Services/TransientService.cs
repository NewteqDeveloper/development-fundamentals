using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifetimeScopes.Services
{
    public class TransientService : ITransient
    {
        public int Counter { get; set; }

        public TransientService()
        {

        }
    }
}
