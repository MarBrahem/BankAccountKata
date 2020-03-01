using System;

namespace BankAcount.Services
{
    /// <summary>
    /// The DateProvider interface
    /// </summary>
    public interface IDateProvider
    {
        /// <summary>
        /// The TodayDate
        /// </summary>
        /// <returns>the Date</returns>
        DateTime TodayDate();
    }
}
