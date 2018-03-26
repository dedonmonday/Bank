using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Bank.Core {
    internal class Customer {
        public string CustomerName { get; set; }
        public string CustomerId { get; set; }
        public string CustomerPin { get; set; }

        public static Customer CreateCustomer(string name, string id, string pin) {
            return new Customer {
                CustomerName = name,
                CustomerId = id,
                CustomerPin = pin
            };
        }
    }
}
