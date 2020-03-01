using System;

namespace BankAcount.Services
{
    /// <summary>
    /// The Date provider class
    /// </summary>
    public class DateProvider : IDateProvider
    {
        /// <summary>
        /// The ToDayDate method implementation
        /// </summary>
        /// <returns>the date</returns>
        public DateTime TodayDate() => DateTime.Today;

    }
}
