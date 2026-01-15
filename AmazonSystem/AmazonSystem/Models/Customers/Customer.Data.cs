using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonSystem.Models.Customers
{
    public partial class Customer
    {
        private string _creditCardDetail;
        public string Email { get; set; }
        public Customer(string email, string card)
        {
            Email = email;
            _creditCardDetail = card;
        }
    }
}
