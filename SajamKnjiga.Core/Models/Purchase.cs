using System;
using System.Collections.Generic;
using System.Text;

namespace SajamKnjiga.Core.Models
{
    public class Purchase
    {
        public Visitor Visitor { get; set; }
        public Book Book { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}