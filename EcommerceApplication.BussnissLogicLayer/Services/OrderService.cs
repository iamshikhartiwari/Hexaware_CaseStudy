using EcommerceApplication.BussnissLogicLayer.Repository;
using EcommerceApplication.BussnissLogicLayer.Services;
using EcommerceApplication.Entity;


namespace EcommerceApplication_BuisnessLayer.Services
{
    public class OrderService:IOrderService
    {
        IOrderRepository _orderRepository;
        public OrderService(OrderRepository orderRepository) {
            _orderRepository = orderRepository;

        }

        public List<Product> getOrderByCustomer(int Customer_ID)
        {
            return _orderRepository.getOrderByCustomer(Customer_ID);
        }

        public bool placeOrder(Order order)
        {
            return _orderRepository.placeOrder(order);
        }
    }
}