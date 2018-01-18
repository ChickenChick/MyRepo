using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cache.Contracts.Contracts;
using SimpleInjector;
using Cache.Business.Services;
using Cache.Contracts.Model;

namespace Cache.Business
{
    public class CompositionModule : ICompositionModule
    {
        public void RegisterTypes(Container container)
        {
            container.Register<IService<BookSummary>, BookService>();
            container.Register<IService<AuthorSummary>, AuthorService>();

        }
    }
}
