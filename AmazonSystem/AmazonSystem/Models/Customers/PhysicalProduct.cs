using AmazonSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonSystem.Models.Customers
{
    public class PhysicalProduct : OrderBase, ITrackable
    {
        public double Weight {get; set;}
        public PhysicalProduct(string name, double amount, double weight): base(name,amount)
        {
            Weight = weight;
        }

        public override void Delivery()
        {
            Console.WriteLine($"Weight {Weight} of order by coustom {CustomerName}");
        }

        public void UpdateTrackingStatus(string status)
        {
            Console.WriteLine($"Order: {CustomerId} with delivery {status}");
        }
    }
}
