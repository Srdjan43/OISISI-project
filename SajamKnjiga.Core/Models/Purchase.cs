
using System;
using System.Globalization;
using SajamKnjiga.Core.Interfaces;

namespace SajamKnjiga.Core.Models
{
    public class Purchase : ISerializable
    {
        public Visitor Visitor { get; set; }
        public Book Book { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public Purchase()
        {
        }

        public string[] ToCSV()
        {
            string[] values =
            {
                Visitor?.MembershipCardNumber ?? "",
                Book?.ISBN ?? "",
                PurchaseDate.ToString("O"),
                Rating.ToString(),
                Comment ?? ""
            };

            return values;
        }

        public void FromCSV(string[] values)
        {
            if (!string.IsNullOrEmpty(values[0]))
            {
                Visitor = new Visitor
                {
                    MembershipCardNumber = values[0]
                };
            }

            if (!string.IsNullOrEmpty(values[1]))
            {
                Book = new Book
                {
                    ISBN = values[1]
                };
            }

            PurchaseDate = DateTime.Parse(
                values[2],
                null,
                DateTimeStyles.RoundtripKind
            );

            Rating = int.Parse(values[3]);
            Comment = values[4];
        }
    }
}
