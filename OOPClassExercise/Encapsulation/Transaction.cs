using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClassExercise.Encapsulation
{
    internal class Transaction
    {
        public DateTime TransactionDateTime { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public TransactionType TransactionType { get; set; }

        public Transaction(decimal amount, string description, string reference, TransactionType type, DateTime date)
        {
            Amount = amount;
            Description = description;
            Reference = reference;
            TransactionType = type;
            TransactionDateTime = date;
        }
    }
}
