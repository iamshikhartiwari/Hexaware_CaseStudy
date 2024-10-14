using System;
using EcommerceApplication.Entity;
using EcommerceApplication.BussnissLogicLayer.Repository;
using System.Data.SqlClient;


namespace EcommerceApplication.BussnissLogicLayer.Repository;

public class CustomerRepository : ICustomerRepository
{
    private ICustomerRepository _customerRepositoryImplementation;

    public bool addCustomer(Customers customer)
    {
        int id = customer.customer_id;
        string name = customer.CName;
        string email = customer.CEmail;
        string password = customer.Password;
        
        // Establish connection
        var conn = DBUtils.PropertyUtil.getPropertyString();
        conn.Open();
            
        // Write query
        string query = "INSERT INTO Customers (customer_id,Name, email, password) VALUES ('"+id+"','" + name + "','" + email + "', '" +
                       password + "')";
        
        // Execute query
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.ExecuteNonQuery();
        
        conn.Close();
        
        return true;
    }
    

    public bool deleteCustomer(int id)
    {
        
        
        // Establish connection
        var conn = DBUtils.PropertyUtil.getPropertyString();
        conn.Open();
            
        // Write query
        string query = "DELETE FROM Customers WHERE customer_id =" + id;
        
        // Execute query
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.ExecuteNonQuery();
        
        conn.Close();
        
        return true;
    }
    
    
}
