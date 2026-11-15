using System;
using System.Collections.Generic;
using System.Text;
using SajamKnjiga.Core.Interfaces;
using System.Globalization;

namespace SajamKnjiga.Core.Models
{
    public class Author : ISerializable
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

        public Author()
        {
            Address = new Address();
            Books = new List<Book>();
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
        IDCardNumber,
        YearsOfExperience.ToString()
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
            IDCardNumber = values[9];
            YearsOfExperience = int.Parse(values[10]);
        }
    }
 }