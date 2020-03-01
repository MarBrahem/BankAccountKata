using BankAcount.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BankAcount
{
    /// <summary>
    /// The Print Services
    /// </summary>
    public class PrintServices : IPrintServices
    {
        #region privates properties

        /// <summary>
        /// The print
        /// </summary>
        private readonly IPrint _print;

        /// <summary>
        /// The StatementHeader const
        /// </summary>
        private const string StatementHeader = Constants.StatementHeader;

        #endregion privates Properties

        #region constructors

        /// <summary>
        ///  Initializes a new instance of <see cref="PrintServices"/>
        /// </summary>
        /// <param name="print">the print</param>
        public PrintServices(IPrint print)
        {
            _print = print;
        }

        #endregion constructors

        #region public method

        /// <summary>
        /// The Print method
        /// </summary>
        /// <param name="accountStatements">the account statements list</param>
        public void Print(IReadOnlyCollection<AccountStatement> accountStatements)
        {
            PrintLines(PrintStatementLines(accountStatements));
        }

        #endregion public method

        #region privates methods

        /// <summary>
        /// The PrintStatementLines method
        /// </summary>
        /// <param name="accountStatements">the account statements</param>
        /// <returns>list of string</returns>
        private List<string> PrintStatementLines(IReadOnlyCollection<AccountStatement> accountStatements)
        {
            List<string> statementslines = new List<string>
            {
                StatementHeader
            };
            statementslines.AddRange(ToPrintStatementLines(accountStatements));
            return statementslines;
        }

        /// <summary>
        /// The ToPrintStatementLines method
        /// </summary>
        /// <param name="statements">the statements</param>
        /// <returns>List of string</returns>
        private IList<string> ToPrintStatementLines(IReadOnlyCollection<AccountStatement> statements)
        {
            IList<string> statementslines = new List<string>();
            var indexBalance = 0;
            statementslines = statements
              .Select(item => string.Format("{0} | {1} | {2}", item.Date, item.Amount, Interlocked.Add(ref indexBalance, item.Amount)))
              .Reverse()
              .ToList();
            return statementslines;
        }

        /// <summary>
        /// The PrintLine method
        /// </summary>
        /// <param name="lines">the lines to print</param>
        private void PrintLines(List<string> lines)
        {
            foreach (var item in lines)
            {
                _print.PrintLine(item);
            }
        }

        #endregion privates methods
    }
}
