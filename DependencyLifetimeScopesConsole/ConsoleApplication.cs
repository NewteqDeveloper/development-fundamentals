using DependencyLifetimeScopesConsole.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyLifetimeScopesConsole
{
    public class ConsoleApplication
    {
        private readonly ITransient transient;
        private readonly IScoped scoped;
        private readonly AnotherApp anotherApp;

        public ConsoleApplication(ITransient transient, IScoped scoped, AnotherApp anotherApp)
        {
            this.transient = transient;
            this.scoped = scoped;
            this.anotherApp = anotherApp;
        }

        public void Run()
        {
            Console.WriteLine("");
            Console.WriteLine("==============================");
            Console.WriteLine("In MAIN app");

            Console.WriteLine($"Current Transient: {transient.Counter}");
            transient.Counter++;
            Console.WriteLine($"One added: {transient.Counter}");

            Console.WriteLine($"Current Scoped: {scoped.Counter}");
            scoped.Counter++;
            Console.WriteLine($"One added: {scoped.Counter}");

            Console.WriteLine("==============================");
            Console.WriteLine("");

            anotherApp.Run();

            Console.WriteLine("");
            Console.WriteLine("==============================");
            Console.WriteLine("In MAIN app AGAIN");

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
