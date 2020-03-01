using BankAcount.Services;
using BankAcount;
using System;

namespace BankAcount
{
    /// <summary>
    /// The Program Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args">the args</param>
        static void Main(string[] args)
        {
            var print = new Print();
            var date = new DateProvider();
            var accountServices = new AccountServices(date);
            PrintServices statementPrinter = new PrintServices(print);
            

            Account account = new Account(accountServices, statementPrinter);

            account.AddDeposit(1500);
            account.AddWithDraw(750);
            account.AddWithDraw(30);
            account.AddDeposit(650);
            account.AddWithDraw(20);

            account.PrintStatement();

            Console.ReadLine();

        }
    }
}
