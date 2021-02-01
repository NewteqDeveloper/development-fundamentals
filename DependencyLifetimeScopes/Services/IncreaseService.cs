namespace DependencyLifetimeScopes.Services
{
    public class IncreaseService : IServiceOne, IServiceTwo
    {
        private readonly ISingleton singleton;
        private readonly IScoped scoped;
        private readonly ITransient transient;

        public IncreaseService(ISingleton singleton, IScoped scoped, ITransient transient)
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
