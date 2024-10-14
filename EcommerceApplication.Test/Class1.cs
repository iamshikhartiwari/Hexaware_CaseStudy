using NUnit.Framework;
using EcommerceApplication.Entity;
using EcommerceApplication.BussnissLogicLayer.Repository;
using EcommerceApplication_BuisnessLayer.Services;
using EcommerceApplication.ExceptionHandling;
using EcommerceApplication.BussnissLogicLayer.Services;


namespace EcommerceApplication_Test
{
    [TestFixture]
    public class EcommerceTest
    {
        //Test for Creating the new Customer using the Customers class object
         [Test]
           [TestCase]
             public void createCustomerTest()
             {
                 Customers customers = new Customers()
                 {
                     customer_id = 100,
                     CName =  "Test",
                     CEmail = "test@gmail.com",
                     Password = "Password"
                 };
                 bool expectedResult = true;
                 CustomerRepository customerRepository = new CustomerRepository();
                 CustomerService customerService = new CustomerService(customerRepository);
                 var result = customerService.createCustomer(customers);
                 Assert.Equals(result, expectedResult);
                 // Assert.AreEqual(expectedResult, result);
             }

        //Deleting the Customer using Customer Id
           [Test]
           [TestCase]
           public void deleteCustomerTest()
           {
               int Customer_Id = 100;
               bool expectedResult = true;
               CustomerRepository customerRepository = new CustomerRepository();
               CustomerService customerService = new CustomerService(customerRepository);
               var result = customerService.deleteCustomer(Customer_Id);
               Assert.Equals(expectedResult, result);
           }

         //Create Product Method Testing
         [Test]
         [TestCase]
         public void createProductTest()
         {
             Product products = new Product() {ProductId = 99,
             ProductName = "Mouse",
             ProductPrice = 22000,
             ProductDescription ="Wireless Mouse",
             quantity = 20
     };
             bool expectedResult = true;
             ProductRepository productRepository = new ProductRepository();
             ProductService productService = new ProductService(productRepository);
              var result = productService.createProduct(products);
             Assert.Equals(expectedResult, result);

         }

       [Test]
        public void TestingCustomExceptionProductNotFound()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            CustomerService customerService = new CustomerService(customerRepository);
            TestDelegate testdelegate = () =>
            {
                bool result = customerService.deleteCustomer(1000);
                if (result == false)
                {
                    throw new CustomerNotFoundException();

                }
            };
            Assert.That(testdelegate, Throws.Exception.TypeOf(typeof(CustomerNotFoundException)), "Customer is Not Available");
        }


        [Test]
        public void TestingCustomExceptionCustomerNotFound()
        {
            ProductRepository productRepository = new ProductRepository();
            ProductService productService = new ProductService(productRepository);
            TestDelegate testdelegate = () =>
            {
                bool result = productService.deleteProduct(1000);
                if (result == false)
                {
                    throw new ProductNotFoundException();

                }
            };
            Assert.That(testdelegate, Throws.Exception.TypeOf(typeof(ProductNotFoundException)), "Product is Not Available");
        }




    }
}