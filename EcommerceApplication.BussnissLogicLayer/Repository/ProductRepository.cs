using System.Data.SqlClient;
using EcommerceApplication.Entity;
using EcommerceApplication.BussnissLogicLayer.Repository;

namespace EcommerceApplication.BussnissLogicLayer.Repository;

public class ProductRepository : IProductRepository
{
    private IProductRepository _productRepositoryImplementation;
    public bool createProduct(Product product)
    {
        int id = product.ProductId;
        string name = product.ProductName;
        string description = product.ProductDescription;
        decimal price = product.ProductPrice;
        int quantity = product.quantity;
        
        
        // Establish connection
        var conn = DBUtils.PropertyUtil.getPropertyString();
        conn.Open();
            
        // Write query
        string query = "INSERT INTO Products (product_id,Name, price, description, stockQuantity) VALUES ('"+id+"','" + name + "','" + price + "', '" +
                       description + "', '"+quantity+"')";
        
        // Execute query
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.ExecuteNonQuery();
        
        conn.Close();
        
        return true;
    }

    public bool deleteProduct(int productId)
    {
        // Establish connection
        var conn = DBUtils.PropertyUtil.getPropertyString();
        conn.Open();
            
        // Write query
        string query = "DELETE FROM Products WHERE product_id =" + productId;
        
        // Execute query
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.ExecuteNonQuery();
        
        conn.Close();
        
        return true;
        
    }
}