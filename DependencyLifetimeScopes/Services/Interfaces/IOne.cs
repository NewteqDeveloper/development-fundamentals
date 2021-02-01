using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifetimeScopes.Services
{
    public interface IOne
    {
        void Increase();
        void Increase(int number);
    }
}
