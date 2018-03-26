using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Bank.Core.Accounts;

namespace Bank.Bank.Core {
    internal class BankManager {
        private readonly string _bankManagerPath;
        public static List<Account> BankAccountList { get; set; } = new List<Account>();

        public BankManager() {
            const string managerFileName = "Bank.exe";
            _bankManagerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, managerFileName);
        }

        public void TransferFunds(Account sender, Account reciever, double amount) {
            if (sender.Withdraw(amount)) {
                reciever.Deposit(amount);
            }
        }

        public bool Validatetransactions(Account account) {
            var transactionLog = account.AccountTransactions;
            double tansactionTotal = 0;
            foreach (var tansaction in transactionLog) {
                if (tansaction.TransactionDestination) {
                    tansactionTotal -= tansaction.TransactionAmount;
                }
                else {
                    tansactionTotal += tansaction.TransactionAmount;
                } 
            }
            //Console.WriteLine("{0} -> {1}", Math.Abs(tansactionTotal - account.AccountBalance), account.AccountBalance);
            return !(Math.Abs(tansactionTotal - account.AccountBalance) > 2);
        }
    }
}
