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
            Account a = Account.CreateAccount(c, "10100101", 100, 0 , 0);
            a.AccountTransactions.Add(Transaction.CreateTransaction("no", 100000, false));

            Console.WriteLine(bankManager.Validatetransactions(a));
            Console.ReadLine();
        }
    }
}
