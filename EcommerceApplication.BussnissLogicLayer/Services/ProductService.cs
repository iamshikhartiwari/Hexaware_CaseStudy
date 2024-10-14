using EcommerceApplication.BussnissLogicLayer.Repository;
using EcommerceApplication.BussnissLogicLayer.Services;
using EcommerceApplication.Entity;


namespace EcommerceApplication_BuisnessLayer.Services
{
    public class ProductService : IProductService
    {

        IProductRepository _productRepository;

        public ProductService( ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool createProduct(Product product)
        {
            return _productRepository.createProduct(product);
        }

        public bool deleteProduct(int Product_ID)
        {
            return _productRepository.deleteProduct(Product_ID);
        }
    }
}