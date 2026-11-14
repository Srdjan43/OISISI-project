using System;
using System.Collections.Generic;
using System.Text;

namespace SajamKnjiga.Core.Models
{
    public class Publisher
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Author Chief { get; set; }
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
    }
}