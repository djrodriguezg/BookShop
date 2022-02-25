using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Request
{
    public class RqAuthor
    {

        [Required]
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        [Required]
        public string Lastname1 { get; set; }
        public string Lastname2 { get; set; }
        [Required]
        public DateTime DateBirth { get; set; }
        [Required]
        public string Hometown { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
