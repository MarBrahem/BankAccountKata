namespace BankAcount
{
    /// <summary>
    /// The Account Class
    /// </summary>
    public class Account : IAccount
    {
        #region private properties

        /// <summary>
        /// The Account Services 
        /// </summary>
        private readonly IAccountServices _accountServices;

        /// <summary>
        /// The Print Services 
        /// </summary>
        private readonly IPrintServices _printServices;

        #endregion private properties

        /// <summary>
        /// Gets or sets the error message
        /// </summary>
        public string ErrorMessage { get; set; }

        #region contructors

        /// <summary>
        /// Initializes a new instance of <see cref="Account"/>
        /// </summary>
        /// <param name="accountServices">The injected acount service</param>
        /// <param name="printServices">The injected print service</param>
        public Account(IAccountServices accountServices, IPrintServices printServices)
        {
            _accountServices = accountServices;
            _printServices = printServices;
        }

        #endregion contructors

        #region public actions

        /// <summary>
        /// Add Desposit to account
        /// </summary>
        /// <param name="amount">The amount value</param>
        public void AddDeposit(int amount)
        {
            if (amount > 0)
            {
                _accountServices.Deposit(amount);
            }
        }

        /// <summary>
        /// Add WithDraw to account
        /// </summary>
        /// <param name="amount">The amount value</param>
        public void AddWithDraw(int amount)
        {
            if (amount > 0)
            {
                _accountServices.WithDraw(amount);
            }
        }

        /// <summary>
        /// The Print Statement
        /// </summary>
        public void PrintStatement()
        {
            _printServices.Print(_accountServices.AccountStatements());
        }

        #endregion public actions
    }
}
