using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence.DATABASE
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int IdAuthor { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Lastname1 { get; set; }
        public string Lastname2 { get; set; }
        public DateTime DateBirth { get; set; }
        public string Hometown { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
