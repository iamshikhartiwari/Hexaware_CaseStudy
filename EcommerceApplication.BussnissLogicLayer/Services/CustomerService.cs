using EcommerceApplication.BussnissLogicLayer.Repository;
using EcommerceApplication.BussnissLogicLayer.Services;
using EcommerceApplication.Entity;


namespace EcommerceApplication.BussnissLogicLayer.Services;


    public class CustomerService : ICustomerService
    {

        ICustomerRepository _customerRepository;
        public CustomerService( CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public bool deleteCustomer(int Customer_ID)
        {
            return  _customerRepository.deleteCustomer(Customer_ID);
        }

       
        public bool createCustomer(Customers customer)
        {
            return _customerRepository.addCustomer(customer);
        }
    }
