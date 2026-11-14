using System;
using System.Collections.Generic;
using System.Text;

namespace SajamKnjiga.Core.Models
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IDCardNumber { get; set; }
        public int YearsOfExperience { get; set; }
        public List<Book> Books { get; set; }
    }
}