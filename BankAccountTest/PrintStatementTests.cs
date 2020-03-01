using BankAcount;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankAccountTest
{
    /// <summary>
    /// The PrintStatementTests class
    /// </summary>
    [TestFixture]
    public class PrintStatementTests
    {
        #region privates properties

        private Mock<IAccountServices> _accountServices;
        private Mock<IPrintServices> _printServices;
        private Account _account;

        #endregion privates properties

        #region public methods

        /// <summary>
        /// Initialise_Test Method
        /// </summary>
        [SetUp]
        public void Initialise_Test()
        {
            _accountServices = new Mock<IAccountServices>();
            _printServices = new Mock<IPrintServices>();
            _account = new Account(_accountServices.Object, _printServices.Object);
        }

        /// <summary>
        /// The Print_Statement_Of_Transactions method
        /// </summary>
        [Test]
        public void Print_Statement_Of_Transactions()
        {
            var accountStatements = AccountStatementList();
            _accountServices.Setup(x => x.AccountStatements()).Returns(accountStatements);
            _account.PrintStatement();
            _printServices.Verify(x => x.Print(accountStatements));
        }

        #endregion public methods

        #region private methods

        /// <summary>
        /// AccountStatementList method
        /// </summary>
        /// <returns>AccountStatement List</returns>
        private static List<AccountStatement> AccountStatementList()
        {
            var statements = new List<AccountStatement>
            {
                new AccountStatement(2000, new DateTime(2020, 2, 11)),
                new AccountStatement(-500, new DateTime(2020, 2, 11)),
                new AccountStatement(100, new DateTime(2020, 3, 1)),
                new AccountStatement(250, DateTime.Now)
            };

            return statements;
        }

        #endregion private methods
    }
}
