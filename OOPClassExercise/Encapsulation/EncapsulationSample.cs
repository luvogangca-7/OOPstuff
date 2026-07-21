using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClassExercise.Encapsulation
{
    internal class EncapsulationSample
    {
        public static void Run()
        {
            ConsoleColor defaultcolor = ConsoleColor.White;
                BankAccount bankAccount = new BankAccount(12345, "John Dube", AccountType.Savings, 680000, "4242424242424242", DateTime.Now);

                Console.WriteLine($"Welcome {bankAccount.AccountHolder}");
                Console.WriteLine($"Your balance is {bankAccount.Balance}");
                Console.WriteLine($"-------------------------------------");

                bool exitApp = false;
                while (!exitApp)
                {
                    Console.WriteLine("Would you like to make a transaction (Y/N)");

                    string userInput = Console.ReadLine();

                    if (userInput.ToUpper() == "Y")
                    {
                        if (bankAccount.Transactions.Count > 0)
                        {
                            Transaction lastTransaction = bankAccount.Transactions[bankAccount.Transactions.Count - 1];

                            Console.WriteLine($"last transaction: Amount {lastTransaction.Amount} Description: {lastTransaction.Description}");

                            Console.WriteLine($"------------------------------------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine($"------------------------------------------------------------------------");

                        }


                        Console.WriteLine("1. Deposit");
                        Console.WriteLine("2. Withdrawal");
                        Console.WriteLine("3. Bank Statement");

                        userInput = Console.ReadLine();

                        if (userInput == "1")
                        {
                            Console.WriteLine("How much do you want to deposit?");
                            string userAmount = Console.ReadLine();

                            Console.WriteLine("What is the reference?");
                            string userReference = Console.ReadLine();

                            Console.WriteLine("What is the description");
                            string userDescription = Console.ReadLine();

                            TransactionResult transactionResult = bankAccount.MakeDeposit(decimal.Parse(userAmount), userReference, userDescription);

                            if (transactionResult == TransactionResult.Successful)
                            {
                                Console.WriteLine($"Transaction successful! Your new balance is : {bankAccount.Balance}");
                            }
                            else
                            {
                                Console.WriteLine("Transaction denied!");
                            }


                        }
                        else if (userInput == "2")
                        {
                            Console.WriteLine("How much do you want to withdraw?");
                            string userAmount = Console.ReadLine();

                            Console.WriteLine("What is the reference?");
                            string userReference = Console.ReadLine();

                            Console.WriteLine("What is the description");
                            string userDescription = Console.ReadLine();

                            TransactionResult transactionResult = bankAccount.MakeWithdrawal(decimal.Parse(userAmount), userReference, userDescription);

                            if (transactionResult == TransactionResult.Successful)
                            {
                                Console.WriteLine($"Transaction successful! Your new balance is : R{bankAccount.Balance}");
                            }
                            else if (transactionResult == TransactionResult.InsufficientFunds)
                            {
                                Console.WriteLine($"Awunamali ta! R{bankAccount.Balance}");
                            }
                            else
                            {
                                Console.WriteLine("Transaction denied!");
                            }

                        }
                        else if (userInput == "3")
                        {

                            foreach (Transaction transaction in bankAccount.Transactions)
                            {
                                Console.WriteLine($"Transaction Date: {transaction.TransactionDateTime}");
                                if (transaction.TransactionType == TransactionType.Withdrawal)
                                {
                                    Console.WriteLine($"Amount: -{transaction.Amount}");
                                }
                                else
                                {
                                    Console.WriteLine($"Amount: {transaction.Amount}");
                                }

                                Console.WriteLine($"Reference: {transaction.Reference}");
                                Console.WriteLine($"Description: {transaction.Description}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Uthini na wena na");
                        }
                        Console.WriteLine("Would you like to make another transaction");
                    }
                    else
                    {

                        Console.WriteLine("Dankie, Danko, Dankwest!!");
                        exitApp = true;
                    }

                }
        }
    }
}
