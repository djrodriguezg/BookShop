using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence.DATABASE
{
    public partial class Book
    {
        public int Idbook { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Numberpages { get; set; }
        public int Idpublisher { get; set; }
        public int Idauthor { get; set; }
        public bool Status { get; set; }

        public virtual Author IdauthorNavigation { get; set; }
        public virtual Publisher IdpublisherNavigation { get; set; }
    }
}
