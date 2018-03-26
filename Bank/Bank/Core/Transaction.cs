using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Bank.Core {
    internal class Transaction {
        public DateTime TransactionDate { get; set; }
        public string TransactionMemo { get; set; }
        public double TransactionAmount { get; set; }
        public bool TransactionDestination { get; set; }

        public static Transaction CreateTransaction(string transactionMemo, double amount, bool sending) {
            return new Transaction {
                TransactionDate = DateTime.Now,
                TransactionMemo = transactionMemo,
                TransactionAmount = amount,
                TransactionDestination = sending
            };
        }
    }
}
