using System.Collections.Generic;

namespace BankAcount
{
    /// <summary>
    /// The Print Statement Services
    /// </summary>
    public interface IPrintServices
    {
        /// <summary>
        /// The Print Method
        /// </summary>
        /// <param name="accountStatements">The account statements</param>
        void Print(IReadOnlyCollection<AccountStatement> accountStatements);
    }
}
