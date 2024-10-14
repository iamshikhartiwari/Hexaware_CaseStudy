using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication.ExceptionHandling
{
    public class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException() : base("Customer Not Found") { }
        public CustomerNotFoundException(string message) : base(message)  { }

        public CustomerNotFoundException(String message,Exception inner) : base(message, inner) { }
    }
}