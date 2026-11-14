using System;
using System.Collections.Generic;
using System.Text;

namespace SajamKnjiga.Core.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public BookGenre Genre { get; set; }
        public int PublicationYear { get; set; }
        public double Price { get; set; }
        public int PageCount { get; set; }
        public List<Author> Authors { get; set; }
        public Publisher Publisher { get; set; }
        public List<Visitor> VisitorsWhoPurchased { get; set; }
        public List<Visitor> VisitorsWhoWishlisted { get; set; }
    }
}
