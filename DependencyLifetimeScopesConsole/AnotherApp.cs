using DependencyLifetimeScopesConsole.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyLifetimeScopesConsole
{
    public class AnotherApp
    {
        private readonly ITransient transient;
        private readonly IScoped scoped;

        public AnotherApp(ITransient transient, IScoped scoped)
        {
            this.transient = transient;
            this.scoped = scoped;
        }

        public void Run()
        {
            Console.WriteLine("");
            Console.WriteLine("==============================");
            Console.WriteLine("In another app");

            Console.WriteLine($"Current Transient: {transient.Counter}");
            transient.Counter++;
            Console.WriteLine($"One added: {transient.Counter}");

            Console.WriteLine($"Current Scoped: {scoped.Counter}");
            scoped.Counter++;
            Console.WriteLine($"One added: {scoped.Counter}");

            Console.WriteLine("==============================");
            Console.WriteLine("");
        }
    }
}
