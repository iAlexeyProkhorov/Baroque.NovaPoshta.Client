using System;

namespace Baroque.NovaPoshta.Client.Extensions
{
    /// <summary>
    /// Represents extensions for simple structure properties formatting
    /// </summary>
    public static class ValueExtensions
    {
        /// <summary>
        /// Parse date into selected format. Default format is 'dd.MM.yyyy'
        /// </summary>
        /// <param name="dateTime">Date time</param>
        /// <param name="format">Date time presentation format. Default 'dd.MM.yyyy'</param>
        /// <returns>String</returns>
        public static string ParseToString(this DateTime? dateTime, string format = "dd.MM.yyyy")
        {
            return dateTime.HasValue ? ParseToString(dateTime.Value, format) : string.Empty;
        }

        /// <summary>
        /// Parse date into selected format. Default format is 'dd.MM.yyyy'
        /// </summary>
        /// <param name="dateTime">Date time</param>
        /// <param name="format">Date time presentation format. Default 'dd.MM.yyyy'</param>
        /// <returns>String</returns>
        public static string ParseToString(this DateTime dateTime, string format = "dd.MM.yyyy")
        {
            return dateTime.ToString(format);
        }

        /// <summary>
        /// Parse bool into int parameter. True = 1, False = 0
        /// </summary>
        /// <param name="boolean">Boolean</param>
        /// <returns>1 or 0</returns>
        public static int PaseToInt(this bool boolean)
        {
            return boolean ? 1 : 0;
        }
    }
}
