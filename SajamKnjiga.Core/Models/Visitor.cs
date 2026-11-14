using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SajamKnjiga.Core.Models
{
    public class Visitor
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
    }
}
