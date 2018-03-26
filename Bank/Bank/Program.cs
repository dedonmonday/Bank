using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Bank.Core;
using Bank.Bank.Core.Accounts;

namespace Bank {
    internal class Program {
        static void Main(string[] args) {
            BankManager bankManager = new BankManager();
            Customer c = Customer.CreateCustomer("A", "adrin", "1003");
            Account a = Account.CreateAccount(c, "10100101", 0, 0 , 0);
            a.Deposit(100000, "Account creation dev");

            Console.WriteLine(bankManager.Validatetransactions(a));
            Console.ReadLine();
        }
    }
}
