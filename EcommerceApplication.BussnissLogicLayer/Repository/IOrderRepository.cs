using EcommerceApplication.Entity;

namespace EcommerceApplication.BussnissLogicLayer.Repository;

public interface IOrderRepository
{
    public bool placeOrder(Order order);
    public List<Product> getOrderByCustomer(int customerId);
}