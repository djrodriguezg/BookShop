using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Response
{
    public class GenericResponse<T>
    {
        public T Data { get; set; }
        public Notification Notification { get; set; }
    }
}
