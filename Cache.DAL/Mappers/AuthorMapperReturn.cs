using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cache.Contracts.Model;
using Cache.DAL.Models;

namespace Cache.DAL.Mappers
{
    class AuthorMapperReturn
    {
        public static Authors ToBussines(AuthorSummary author)
        {
            return new Authors()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                BirthDay = author.BirthDay
            };
        }
    }
}
