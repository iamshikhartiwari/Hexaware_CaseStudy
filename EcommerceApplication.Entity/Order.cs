namespace EcommerceApplication.Entity;

public class Order
{
    public string OrderId { get; set; }
    public string CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Price { get; set; }
    public string address { get; set; }
}