using BLL.Service;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace API.App_Start
{
    //public class NinjectDependencyResoslver:IDependencyScope, IDisposable
    //{
      
        
    //        private IKernel kernel;
    //        public NinjectDependencyResolver(IKernel kernelParam)
    //        {
    //            kernel = kernelParam;
    //            AddBindings();
    //        }
    //        public void Dispose()
    //        {
    //            Dispose();
    //        }

    //        public object GetService(Type serviceType)
    //        {
    //            return kernel.TryGet(serviceType);
    //        }

    //        public IEnumerable<object> GetServices(Type serviceType)
    //        {
    //            return kernel.GetAll(serviceType);
    //        }
    //        private void AddBindings()
    //        {
    //            kernel.Bind<IBookService>().To<BookService>();
    //        }
        
    //}
}