using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Contracts.Model
{
    public class BookSummary
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Url { get; set; }

        public int AuthorId { get; set; }
    }
}
