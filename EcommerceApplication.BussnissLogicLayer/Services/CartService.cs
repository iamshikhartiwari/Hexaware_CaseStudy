using EcommerceApplication.BussnissLogicLayer.Repository;
using EcommerceApplication.BussnissLogicLayer.Services;
using EcommerceApplication.Entity;

namespace EcommerceApplication.BussnissLogicLayer.Services;

public class CartService : ICartService
{
    private readonly ICartRepository _cartRepository;

    public CartService(CartRepository cartRepository)
    {
        _cartRepository = cartRepository;
    }
    
    
    public bool addToCart(int Cart_ID, Product product, Customers customer, int Quantity)
    {
        return _cartRepository.addToCart(Cart_ID,product, customer, Quantity);
    }

    public List<Product> getAllFromCart(int Customer_ID)
    {
        return _cartRepository.getAllFromCart(Customer_ID);
    }

    public bool removeFromCart(int Cart_ID)
    {
        return _cartRepository.removeFromCart(Cart_ID);
    }

}