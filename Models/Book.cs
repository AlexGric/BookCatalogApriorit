using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogApriorit.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public DateTime PublishYear { get; set; }
        public string PublisherName { get; set; }
    }
}
