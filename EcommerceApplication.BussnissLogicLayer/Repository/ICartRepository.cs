using EcommerceApplication.Entity;

namespace EcommerceApplication.BussnissLogicLayer.Repository;

internal interface ICartRepository
{
   public bool addToCart(int Cart_ID, Product product,Customers customer, int quantity);
   public bool removeFromCart(int Cart_ID);
   public List<Product> getAllFromCart(int customerid);
}