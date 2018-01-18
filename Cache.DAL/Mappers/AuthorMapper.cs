using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cache.Contracts.Model;
using Cache.DAL.Models;

namespace Cache.DAL.Mappers
{

    class AuthorMapper
    {
        public static AuthorSummary ToBussines(Authors author)
        {
            return new AuthorSummary()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                BirthDay = author.BirthDay
            };
        }
    }
}
