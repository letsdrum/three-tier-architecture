using Ninject.Modules;
using ThreeTierArchitecture.BLL.Interfaces;
using ThreeTierArchitecture.BLL.Services;

namespace ThreeTierArchitecture.Web.Util
{
    public class OrderModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderService>().To<OrderService>();
        }
    }
}