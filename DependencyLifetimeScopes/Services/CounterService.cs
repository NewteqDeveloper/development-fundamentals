namespace DependencyLifetimeScopes.Services
{
    public class CounterService : ITransient, ISingleton, IScoped
    {
        public int Counter { get; set; }
    }
}
