using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class DTO_BOOK
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int NumberPages { get; set; }
        public int IdPublisher { get; set; }
        public int IdAuthor { get; set; }
    }
}
