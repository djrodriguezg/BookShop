using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class DTO_PUBLISHER
   {
        public string Name { get; set; }
        public string MailingAddress { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public int MaxBooksReg { get; set; }
    }
}
