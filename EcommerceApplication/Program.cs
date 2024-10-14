// See https://aka.ms/new-console-template for more information

using System;
using EcommerceApplication.BussnissLogicLayer.Repository;
using EcommerceApplication.Entity;
namespace MyNamespace
{
    public class CustomerRepositorys
    {
        public static void Main(String[] args)
        {
            CustomerRepository _customerRepository = new CustomerRepository();
            int cust = 9449;
            
            _customerRepository.deleteCustomer(cust);
        }
    }
}
