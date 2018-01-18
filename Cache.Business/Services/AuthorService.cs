using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cache.Contracts.Contracts;
using Cache.Contracts.Model;

namespace Cache.Business.Services
{
    class AuthorService : IService<AuthorSummary>
    {
        IRepository<AuthorSummary> _Authrepo;

        public AuthorService(IRepository<AuthorSummary> Authrepo)
        {
            _Authrepo = Authrepo;
        }
        public void Create(AuthorSummary book)
        {
            _Authrepo.Create(book);
        }

        public void Delete(int id)
        {
            _Authrepo.Delete(id);
        }

        public IEnumerable<AuthorSummary> GetSummary()
        {
            return _Authrepo.GetSummary();
        }

        public void Update(AuthorSummary author)
        {
            _Authrepo.Update(author);
        }
        
    }
}
