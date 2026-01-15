using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonSystem.Core
{
    public interface ITrackable
    {
        void UpdateTrackingStatus(string status);
    }

    public abstract class OrderBase
    {
        public static int TotalOrderProcessed = 0;
        protected string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }
        public OrderBase(string customerName, double amount)
        {
            CustomerName = customerName;
            Amount = amount;
            CustomerId = "Order Id : " + Guid.NewGuid().ToString() + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss");
        }
        public abstract void Delivery();
    }
}