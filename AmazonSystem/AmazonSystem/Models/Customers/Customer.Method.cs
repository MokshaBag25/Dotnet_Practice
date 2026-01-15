using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonSystem.Models.Customers
{
    public partial class Customer
    {
        public void ShowAccountInfo()
        {
            string cardNumber = _creditCardDetail;
            Console.WriteLine($"Customer: {Email} | Payment {cardNumber}" );
        }
    }
}
