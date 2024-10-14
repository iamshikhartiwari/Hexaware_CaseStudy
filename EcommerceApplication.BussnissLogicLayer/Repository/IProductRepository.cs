using EcommerceApplication.Entity;

namespace EcommerceApplication.BussnissLogicLayer.Repository;

public interface IProductRepository
{
    public bool createProduct(Product product);
    public bool deleteProduct(int productId);
}