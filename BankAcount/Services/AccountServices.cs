using BankAcount.Services;
using System.Collections.Generic;

namespace BankAcount
{
    /// <summary>
    /// The Account Services
    /// </summary>
    public class AccountServices : IAccountServices
    {
        #region private properties

        /// <summary>
        /// the Acount statement 
        /// </summary>
        private readonly List<AccountStatement> _accountStatements = new List<AccountStatement>();

        /// <summary>
        /// the date provider
        /// </summary>
        private readonly IDateProvider _date;

        #endregion private properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="AccountServices"/>
        /// </summary>
        /// <param name="configuration">The configuration</param>
        public AccountServices(IDateProvider date)
        {
            _date = date;
        }

        #endregion Constructors

        #region public method

        /// <summary>
        /// The Deposit Method
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                AccountStatement deposit = new AccountStatement()
                {
                    Amount = amount,
                    Date = _date.TodayDate()
                };
                _accountStatements.Add(deposit);
            }
        }

        /// <summary>
        /// the WithDraw method
        /// </summary>
        /// <param name="amount"></param>
        public void WithDraw(int amount)
        {
            if (amount > 0)
            {
                AccountStatement withdraw = new AccountStatement()
                {
                    Amount = -amount,
                    Date = _date.TodayDate()
                };
                _accountStatements.Add(withdraw);
            }
        }

        /// <summary>
        /// The AccountStatements method
        /// </summary>
        /// <returns>Account Statements list</returns>
        public IReadOnlyCollection<AccountStatement> AccountStatements()
        {
            return _accountStatements;
        }

        #endregion public method
    }
}
