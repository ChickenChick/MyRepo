using Cache.Contracts.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using Cache.DAL.Repositories;
using Cache.Contracts.Model;

namespace Cache.DAL
{
    public class CompositionModule : ICompositionModule
    {
        public void RegisterTypes(Container container)
        {
            container.Register<IRepository<AuthorSummary>, AuthorRepository>();
            container.Register<IRepository<BookSummary>, BookRepository>();
        }
    }
}
