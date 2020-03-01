namespace BankAcount
{
    /// <summary>
    /// The Acount Interface
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// The Add Deposit
        /// </summary>
        /// <param name="amount"></param>
        void AddDeposit(int amount);

        /// <summary>
        /// The Add Withdraw
        /// </summary>
        /// <param name="amount"></param>
        void AddWithDraw(int amount);

        /// <summary>
        /// The PrintStatement
        /// </summary>
        void PrintStatement();
    }
}
