using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Bank.Core.Accounts {
    internal class Account {
        public Account() {
            AccountTransactions = new List<Transaction>();
        }

        public Customer AccountHolder { get; set; }
        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; }
        public double AccountTotalDeposit { get; set; }
        public double AccountTotalWithdrawl { get; set; }
        public List<Transaction> AccountTransactions { get; }
        public int TransactionAmount => AccountTransactions.Count;

        public static Account CreateAccount(Customer holder, string accountnumber, double balance, double deposit,
            double withdrawl) {
            var account =  new Account {
                AccountHolder = holder,
                AccountNumber = accountnumber,
                AccountBalance = balance,
                AccountTotalDeposit = deposit,
                AccountTotalWithdrawl = withdrawl
            };
            BankManager.BankAccountList.Add(account);
            return account;
        }

        public bool Withdraw(double amount, string memo = "") {
            if (amount > AccountBalance) {
                Debug.WriteLine("Account balance is too low for account {0}", AccountNumber);
                return false;
            }
            
            AccountBalance -= amount;
            Debug.WriteLine("Withdrawed {0} into account {1}", amount , AccountNumber);
            AccountTransactions.Add(Transaction.CreateTransaction(memo, amount, true));
            return true;
        }

        public void Deposit(double amount, string memo = "") {
            AccountBalance += amount;
            Debug.WriteLine("Deposited {0} into account {1}", amount, AccountNumber);
            AccountTransactions.Add(Transaction.CreateTransaction(memo, amount, false));
        }
    }
}
