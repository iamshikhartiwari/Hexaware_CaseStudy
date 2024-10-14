using EcommerceApplication.Entity;
using System.Data.SqlClient;
using DBUtils;

namespace EcommerceApplication.BussnissLogicLayer.Repository;

public class CartRepository : ICartRepository
{
    private ICartRepository _cartRepositoryImplementation;
    
    
   public bool addToCart(int Cart_ID, Product product, Customers customer, int Quantity)
        {
            using (var conn = PropertyUtil.getPropertyString())
            {
                conn.Open();
                string query = "insert into Cart ( Cart_ID,Customer_ID,Product_ID,Quantity) values('" + Cart_ID + "', '"+ customer.customer_id +"','" + product.ProductId + "','" + Quantity + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int roweffect = cmd.ExecuteNonQuery();

                if (roweffect > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }
        }

        public List<Product> getAllFromCart( int Customer_ID)
        {
             List<Product> products = new List<Product>();
            using (var conn = PropertyUtil.getPropertyString())
            {
                conn.Open();
                string query = "Select p.Product_ID,p.Product_name,p.Price,p.Description,c.Quantity from Cart c inner join Products p on c.Product_ID = p.Product_ID where c.Customer_ID = '" + Customer_ID + "'";
                SqlCommand comm = new SqlCommand(query, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read()) {
                    //()
                    Product product = new Product()
                    {
                        ProductId = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        ProductPrice = reader.GetInt32(0),
                        ProductDescription = reader.GetString(3),
                        quantity = reader.GetInt32(4)
                    };
                    products.Add(product); }
            }
            return products;
            }
            
        

        public bool removeFromCart(int Cart_ID)
        {
            using (var conn = PropertyUtil.getPropertyString())
            {
                conn.Open();

                string query = "delete from Cart where Cart_ID = '" + Cart_ID + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                int roweffect = cmd.ExecuteNonQuery();

                if (roweffect > 0)
                {
                    return true;
                }
                return false;

            }
        }
    

}