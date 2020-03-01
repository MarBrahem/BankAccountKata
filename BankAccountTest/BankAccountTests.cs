using BankAcount;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankAccountTest
{
    /// <summary>
    /// The BankAccountTests class
    /// </summary>
    [TestFixture]
    public class BankAccountTests
    {
        #region privates properties

        private Mock<IAccountServices> _accountServices;
        private Mock<IPrintServices> _printServices;
        private Account _account;
        private const int ToDepositAmount = 1500;
        private const int ToWithdrawalAmount = 200;

        #endregion privates properties

        #region public methods

        /// <summary>
        /// Initialise_Test method
        /// </summary>
        [SetUp]
        public void Initialise_Test()
        {
            _accountServices = new Mock<IAccountServices>();
            _printServices = new Mock<IPrintServices>();
            _account = new Account(_accountServices.Object, _printServices.Object);
        }

        /// <summary>
        /// The Add_A_Deposit_Transaction method
        /// </summary>
        [Test]
        public void Add_A_Deposit_Transaction()
        {
            _account.AddDeposit(ToDepositAmount);
            _accountServices.Verify(x => x.Deposit(ToDepositAmount));
        }

        /// <summary>
        /// The Add_A_Withdrawal_Transaction method
        /// </summary>
        [Test]
        public void Add_A_Withdrawal_Transaction()
        {
            _account.AddWithDraw(ToWithdrawalAmount);
            _accountServices.Verify(x => x.WithDraw(ToWithdrawalAmount));
        }

        #endregion public methods
    }
}
