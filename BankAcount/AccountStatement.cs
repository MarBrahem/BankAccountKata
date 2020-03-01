using System;

namespace BankAcount
{
    /// <summary>
    /// The Account Class
    /// </summary>
    public class AccountStatement
    {
        #region public properties 

        /// <summary>
        /// The Amount value
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// The Date value
        /// </summary>
        public DateTime Date { get; set; }

        #endregion public properties 

        #region contructors

        /// <summary>
        /// Initializes a new instance of <see cref="AccountStatement"/>
        /// </summary>
        public AccountStatement()
        {
        }
        /// <summary>
        /// Initializes a new instance of <see cref="AccountStatement"/>
        /// </summary>
        /// <param name="amount">the amount</param>
        /// <param name="date">the date</param>
        public AccountStatement(int amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="AccountStatement"/>
        /// </summary>
        /// <param name="amount">the amount</param>
        public AccountStatement(int amount)
        {
            Amount = amount;
        }

        #endregion contructors

        /// <summary>
        /// The ToString overrided method
        /// </summary>
        /// <returns>a string</returns>
        public override string ToString() =>
            $"{nameof(AccountStatement)} {{ {nameof(Date)}: {Date:dd/MM/yyyy}, {nameof(Amount)}: {Amount} }}";
    }
}
