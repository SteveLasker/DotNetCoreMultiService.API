using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiService.API.Models
{
    public class Customer
    {
        public Customer(string customerId, string name)
        {
            this.CustomerId = customerId;
            this.Name = name;
        }
        public string CustomerId { get; set; }
        public string Name { get; set; }

    }
}
