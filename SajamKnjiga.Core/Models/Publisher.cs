
using System;
using System.Collections.Generic;
using SajamKnjiga.Core.Interfaces;

namespace SajamKnjiga.Core.Models
{
    public class Publisher : ISerializable
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Author Chief { get; set; }
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }

        public Publisher()
        {
            Authors = new List<Author>();
            Books = new List<Book>();
        }

        public string[] ToCSV()
        {
            string[] values =
            {
                Code,
                Name,
                Chief?.IDCardNumber ?? ""
            };

            return values;
        }

        public void FromCSV(string[] values)
        {
            Code = values[0];
            Name = values[1];

            if (!string.IsNullOrEmpty(values[2]))
            {
                Chief = new Author
                {
                    IDCardNumber = values[2]
                };
            }
            else
            {
                Chief = null;
            }
        }
    }
}
