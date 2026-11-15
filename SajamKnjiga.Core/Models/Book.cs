
using System;
using System.Collections.Generic;
using SajamKnjiga.Core.Interfaces;
using System.Globalization;

namespace SajamKnjiga.Core.Models
{
    public class Book : ISerializable
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

        public Book()
        {
            Authors = new List<Author>();
            VisitorsWhoPurchased = new List<Visitor>();
            VisitorsWhoWishlisted = new List<Visitor>();
        }

        public string[] ToCSV()
        {
            string[] values =
            {
                ISBN,
                Title,
                Genre.ToString(),
                PublicationYear.ToString(),
                Price.ToString(CultureInfo.InvariantCulture),
                PageCount.ToString()
            };

            return values;
        }

        public void FromCSV(string[] values)
        {
            ISBN = values[0];
            Title = values[1];
            Genre = Enum.Parse<BookGenre>(values[2]);
            PublicationYear = int.Parse(values[3]);
            Price = double.Parse(values[4], CultureInfo.InvariantCulture);
            PageCount = int.Parse(values[5]);
        }
    }
}
