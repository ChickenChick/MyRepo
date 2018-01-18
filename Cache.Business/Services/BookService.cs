using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cache.Contracts.Contracts;
using Cache.Contracts.Model;

namespace Cache.Business.Services
{
    class BookService: IService<BookSummary>
    {
        IRepository<BookSummary> _Bookrepo;

        public BookService(IRepository<BookSummary> Bookrepo)
        {
            _Bookrepo = Bookrepo;
        }

        public void Create(BookSummary book)
        {
            _Bookrepo.Create(book);
        }
            public void Delete(int id)
        {
            _Bookrepo.Delete(id);
        }

        IEnumerable<BookSummary> IService<BookSummary>.GetSummary()
        {
            return _Bookrepo.GetSummary();
        }

        public void Update(BookSummary book)
        {
            _Bookrepo.Update(book);
        }
    }
}
