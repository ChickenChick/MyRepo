using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cache.Contracts.Model;

namespace Cache.Contracts.Contracts
{
    public interface IService<T>
    {
        IEnumerable<T> GetSummary();
        void Create(T item);
        void Delete(int id);
        void Update(T item);
    }
}
