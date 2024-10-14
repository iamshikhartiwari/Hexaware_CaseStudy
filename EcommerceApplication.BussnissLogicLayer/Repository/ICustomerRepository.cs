using EcommerceApplication.Entity;

namespace EcommerceApplication.BussnissLogicLayer.Repository;

public interface ICustomerRepository
{
   public bool addCustomer(Customers customer);
   public bool deleteCustomer(int customer_id);
}