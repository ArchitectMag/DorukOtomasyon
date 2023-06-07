using SimpleInjector;
using JobOrderStatusReport.Business.Abstract;
using JobOrderStatusReport.Business.Concrete;

namespace JobOrderStatusReport.Utilities.SimpleInjection
{
    public static class DependencyContainer
    {
        static Container container;
        public static Container Container { get { return container; } }

        static DependencyContainer()
        {
            container = new Container();
            container.Register<IJobOrderService, JopOrderManager>();
        }
    }
}
