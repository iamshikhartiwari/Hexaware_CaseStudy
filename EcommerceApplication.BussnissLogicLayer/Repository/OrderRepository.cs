using EcommerceApplication.Entity;
using EcommerceApplication.BussnissLogicLayer.Repository;
using System.Data.SqlClient;
using DBUtils;
using EcommerceApplication.BussnissLogicLayer.Repository;


namespace EcommerceApplication.BussnissLogicLayer.Repository;

public class OrderRepository : IOrderRepository
{
    private IOrderRepository _orderRepositoryImplementation;


  

    public List<Product> getOrderByCustomer(int Customer_ID)
    {
        List<Product> products = new List<Product>();
        using (var conn = DBUtils.PropertyUtil.getPropertyString())
        {
            conn.Open();

            string query = "select p.Product_ID,p.Product_name,p.Price,oi.QuantityOfOrderItems from OrderItems oi" +
                           " join Products p on oi.Product_ID = p.Product_Id join Orders o on oi.Order_ID = o.Order_ID where o.Customer_ID = '" + Customer_ID + "'";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Product product = new Product
                {
                    ProductId = reader.GetInt32(0),
                    ProductName = reader.GetString(1),
                    ProductPrice = reader.GetInt32(2),
                    quantity = reader.GetInt32(3)
                };

                products.Add(product);
            }


        }
        return products;
    }


    public bool placeOrder(Order order)
    {
        using (var conn = DBUtils.PropertyUtil.getPropertyString())
        {
            conn.Open();
            string query = "insert into Orders (Order_Id,Customer_ID,OrderDate,TotalPrice,ShippingAddress) values( '" + order.OrderId + "','" + order.CustomerId + "','" + order.OrderDate + "','" + order.Price + "','" + order.address + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int rowscount = cmd.ExecuteNonQuery();

            if (rowscount > 0)
            {
                return true;
            }
            return false;

        }


    }



 
}