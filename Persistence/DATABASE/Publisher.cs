using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence.DATABASE
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public int IdPublisher { get; set; }
        public string Name { get; set; }
        public string MailingAddress { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public int MaxBooksReg { get; set; }
        public int? BooksRegCount { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
