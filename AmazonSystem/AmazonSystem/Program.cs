using AmazonSystem.Core;
using AmazonSystem.Models;
using AmazonSystem.Models.Customers;

namespace AmazonSystem.App
{
    class program
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer("abc@gmail.com", "45672398");
            customer.ShowAccountInfo();
        }
    }
}