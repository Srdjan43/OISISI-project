
using System;
using System.Collections.Generic;
using System.Globalization;
using SajamKnjiga.Core.Interfaces;

namespace SajamKnjiga.Core.Models
{
    public class Visitor : ISerializable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string MembershipCardNumber { get; set; }
        public int CurrentMembershipYear { get; set; }
        public VisitorStatus Status { get; set; }
        public double AverageReviewRating { get; set; }
        public List<Purchase> Purchases { get; set; }
        public List<Book> Wishlist { get; set; }

        public Visitor()
        {
            Address = new Address();
            Purchases = new List<Purchase>();
            Wishlist = new List<Book>();
        }

        public string[] ToCSV()
        {
            string[] values =
            {
                FirstName,
                LastName,
                DateOfBirth.ToString("O"),
                Address.Street,
                Address.Number,
                Address.City,
                Address.Country,
                PhoneNumber,
                Email,
                MembershipCardNumber,
                CurrentMembershipYear.ToString(),
                Status == VisitorStatus.VIP ? "V" : "R",
                AverageReviewRating.ToString(CultureInfo.InvariantCulture)
            };

            return values;
        }

        public void FromCSV(string[] values)
        {
            FirstName = values[0];
            LastName = values[1];
            DateOfBirth = DateTime.Parse(values[2], null, DateTimeStyles.RoundtripKind);

            Address = new Address(
                values[3],
                values[4],
                values[5],
                values[6]
            );

            PhoneNumber = values[7];
            Email = values[8];
            MembershipCardNumber = values[9];
            CurrentMembershipYear = int.Parse(values[10]);

            Status = values[11] == "V"
                ? VisitorStatus.VIP
                : VisitorStatus.Regular;

            AverageReviewRating = double.Parse(
                values[12],
                CultureInfo.InvariantCulture
            );
        }
    }
}
