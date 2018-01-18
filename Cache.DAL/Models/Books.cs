    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

namespace Cache.DAL.Models
{    
    internal partial class Books
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        public int AuthorId { get; set; }

        public int Price { get; set; }

        public string Url { get; set; }

        public virtual Authors Authors { get; set; }
    }
}
