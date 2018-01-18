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
    class AuthorRepository : IRepository<AuthorSummary>
    {
        public void Create(AuthorSummary book)
        {
            using (var db = new Model1())
            {
                Authors bookMapped = AuthorMapperReturn.ToBussines(book);
                db.Entry(bookMapped).State = EntityState.Added;
                db.SaveChanges();
            }
        }   
        
        public void Delete(int id)
        {
            using (var db = new Model1())
            {
                Authors selectedAuth = db.Authors.Find(id);
                db.Authors.Remove(selectedAuth);
                db.SaveChanges();
            }
        }

        public IEnumerable<AuthorSummary> GetSummary()
        {
            using (var db = new Model1())
            {
                return db.Authors.Select(AuthorMapper.ToBussines).ToList();
            }
        }

        public void Update(AuthorSummary author)
        {
            using (var db = new Model1())
            {
                Authors authorMapped = AuthorMapperReturn.ToBussines(author);
                db.Entry(authorMapped).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
