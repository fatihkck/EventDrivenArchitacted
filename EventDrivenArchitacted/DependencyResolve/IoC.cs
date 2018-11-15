using Unity;

namespace EventDrivenArchitacted.DependencyResolve
{
    public static class IoC
    {
        private static UnityContainer container;
        public static UnityContainer Container
        {
            get
            {
                if (container == null)
                    container = new UnityContainer();

                return container;
            }
        }
    }
}
