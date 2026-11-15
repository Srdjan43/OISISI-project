using System;
using System.Collections.Generic;
using System.Text;
using SajamKnjiga.Core.Interfaces;

namespace SajamKnjiga.Core.Models
{
    public class Address : ISerializable
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address()
        {
        }

        public Address(string street, string number, string city, string country)
        {
            Street = street;
            Number = number;
            City = city;
            Country = country;
        }

        public string[] ToCSV()
        {
            string[] values =
            {
                Street,
                Number,
                City,
                Country
            };

            return values;
        }

        public void FromCSV(string[] values)
        {
            Street = values[0];
            Number = values[1];
            City = values[2];
            Country = values[3];
        }
    }
}