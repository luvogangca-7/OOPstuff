using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClassExercise.Encapsulation
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public AccountType AccountType { get; set; }
        public decimal Balance { get; set; }
        public string CardNumber { get; set; }
        public DateTime CardExpiryDate { get; set; }

        public List<Transaction> Transactions { get; set; }

        public BankAccount(int accountNumber, string accountHolder, AccountType accountType, decimal balance, string cardNumber, DateTime cardExpiryDate)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            AccountType = accountType;
            Balance = balance;
            CardNumber = cardNumber;
            CardExpiryDate = cardExpiryDate;
            Transactions = new List<Transaction>();
        }

        public TransactionResult MakeDeposit(decimal amount, string reference, string description)
        {
            Balance += amount;

            Transaction transaction = new Transaction(amount, description, reference, TransactionType.Deposit, DateTime.Now);

            Transactions.Add(transaction);

            return TransactionResult.Successful;


        }
        public TransactionResult MakeWithdrawal(decimal amount, string reference, string description)
        {
            if(Balance >= amount)
            {
                Balance -= amount;

                Transaction transaction = new Transaction(amount, description, reference, TransactionType.Withdrawal, DateTime.Now);

                Transactions.Add(transaction);

                return TransactionResult.Successful;
            }
            else
            {
                Console.WriteLine("You are broke!");
                return TransactionResult.InsufficientFunds;
            }
            

            


        }




    }
}
