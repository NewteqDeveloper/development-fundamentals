using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifetimeScopesConsole.Services
{
    public interface ITransient : ICounter
    {
    }
}
