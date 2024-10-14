using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication.ExceptionHandling
{
    public class OrderNotFoundException : Exception
    {
        public OrderNotFoundException():base("Order Not Found Exception"){}
        public OrderNotFoundException(string message):base(message){}

        public OrderNotFoundException(string message, Exception inner):base(message, inner){}
    }
}