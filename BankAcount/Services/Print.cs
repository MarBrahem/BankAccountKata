using BankAcount.Services;
using System;

namespace BankAcount
{
    /// <summary>
    /// The Print class
    /// </summary>
    public class Print : IPrint
    {
        /// <summary>
        /// The PrintLine method implementation
        /// </summary>
        /// <param name="line">The line</param>
        public void PrintLine(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                throw new ArgumentNullException("line is required");
            }
            Console.WriteLine(line);
        }
    }
}
