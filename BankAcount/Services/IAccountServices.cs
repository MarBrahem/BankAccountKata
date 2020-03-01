using System.Collections.Generic;

namespace BankAcount
{
    /// <summary>
    /// The IAccount Services interface
    /// </summary>
    public interface IAccountServices
    {
        /// <summary>
        /// Deposit new amount
        /// </summary>
        /// <param name="amount">The amount to desposit</param>
        /// <returns>void</returns>
        void Deposit (int amount);

        /// <summary>
        /// WithDraw method
        /// </summary>
        /// <param name="amount">The amount to WithDraw</param>
        /// <returns>void</returns>
        void WithDraw(int amount);

        /// <summary>
        /// Account Statements method
        /// </summary>
        /// <returns>All Account Statements</returns>
        IReadOnlyCollection<AccountStatement> AccountStatements();
    }
}
