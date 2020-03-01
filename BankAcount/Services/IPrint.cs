using System;
using System.Collections.Generic;
using System.Text;

namespace BankAcount.Services
{
    /// <summary>
    /// The Print Interface
    /// </summary>
    public interface IPrint
    {
        /// <summary>
        /// The PrintLine Method
        /// </summary>
        /// <param name="line">the line</param>
        void PrintLine(string line);
    }
}
