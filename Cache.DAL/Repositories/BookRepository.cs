using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cache.Contracts.Contracts;
using Cache.Contracts.Model;
using Cache.DAL.Mappers;
using Cache.DAL.Models;

namespace Cache.DAL.Repositories
{
    class BookRepository : IRepository<BookSummary>
    {
        public IEnumerable<BookSummary> GetSummary()
        {
            using (var db = new Model1())
            {
                return db.Books.Select(BookMapper.ToBussines).ToList();
            }
        }
        public void Create(BookSummary book)
        {
            using (var db = new Model1())
            {
                Books bookMapped = BookMapperReturn.ToBussines(book);
                db.Entry(bookMapped).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new Model1())
            {
                Books selectedBook = db.Books.Find(id);
                db.Books.Remove(selectedBook);
                db.SaveChanges();
            }
        }
        public void Update(BookSummary book)
        {
            using (var db = new Model1())
            {
                Books bookMapped = BookMapperReturn.ToBussines(book);
                db.Entry(bookMapped).State = EntityState.Modified;
                db.SaveChanges();
            }
           
        }
    }
}
