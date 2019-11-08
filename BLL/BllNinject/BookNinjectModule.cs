using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos;
using Ninject.Modules;

namespace BLL.BllNinject
{
   public class BookNinjectModule : NinjectModule
    {
        private string BookConnection;
        public BookNinjectModule(string connection)
        {
            this.BookConnection = connection;
        }
        public override void Load()
        {
            Bind<IBookUoW>().To<BookUoW>().WithConstructorArgument(BookConnection);     
        }
    }
}
