using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifetimeScopes.Services
{
    public class LifetimeOneService : IOne
    {
        private readonly ISingleton singleton;
        private readonly IScoped scoped;
        private readonly ITransient transient;

        public LifetimeOneService(ISingleton singleton, IScoped scoped, ITransient transient)
        {
            this.singleton = singleton;
            this.scoped = scoped;
            this.transient = transient;
        }

        public void Increase()
        {
            singleton.Counter++;
            scoped.Counter++;
            transient.Counter++;
        }

        public void Increase(int number)
        {
            singleton.Counter += number;
            scoped.Counter += number;
            transient.Counter += number;
        }
    }
}
