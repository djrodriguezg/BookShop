using Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ILibrary
    {
        public Object InsertBook(RqBook rqBook);

        public Object InsertAuthor(RqAuthor rqAuthor);

        public Object InsertPublisher(RqPublisher rqPublisher);
    }
}
