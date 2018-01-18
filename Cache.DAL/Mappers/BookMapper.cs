using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cache.Contracts.Model;
using Cache.DAL.Models;

namespace Cache.DAL.Mappers
{
    internal class BookMapper
    {
        public static BookSummary ToBussines(Books book)
        {
            return new BookSummary()
            {
                Id = book.Id,
                Name = book.Name,
                Price = book.Price,
                Url = book.Url,
                AuthorId = book.AuthorId
            };
        }
    }
}
