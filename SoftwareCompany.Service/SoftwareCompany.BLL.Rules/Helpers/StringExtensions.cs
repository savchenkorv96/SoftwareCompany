using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SoftwareCompany.BLL.Rules.Helpers
{
    public static class StringExtensions
    {
        /// <summary>
        /// The is string.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsString(this string value)
        {
            bool isValid = Regex.IsMatch(value, @"^[a-zA-Z]+$");
            return isValid;
        }

        /// <summary>
        /// The is string.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="minLength">
        /// The min length.
        /// </param>
        /// <param name="maxLength">
        /// The max length.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsString(this string value, int minLength, int maxLength)
        {
            bool isValid = value.Length >= minLength && value.Length <= maxLength && value.IsString();
            return isValid;
        }

        /// <summary>
        /// The is string with numbers.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsStringWithNumbers(this string value)
        {
            bool isValid = Regex.IsMatch(value, @"^[a-zA-Z0-9]+$");
            return isValid;
        }

        /// <summary>
        /// The is numbers.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsNumbers(this string value)
        {
            bool isValid = Regex.IsMatch(value, @"^[0-9]+$");
            return isValid;
        }

        /// <summary>
        /// The is string with numbers and underscores.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsStringWithNumbersAndUnderscores(this string value)
        {
            bool isValid = Regex.IsMatch(value, @"^[a-zA-Z0-9_]+$");
            return isValid;
        }

        /// <summary>
        /// The is string with additional symbols.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="addition">
        /// The addition.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsStringWithAdditionalSymbols(this string value, string addition)
        {
            string pattern = string.Format(@"^[a-zA-Z{0}]+$", addition);
            bool isValid = Regex.IsMatch(value, pattern);
            return isValid;
        }

        /// <summary>Checks if the string is valid.</summary>
        /// <param name="value">The value.</param>
        /// <param name="addition">The addition.</param>
        /// <param name="minLength">The min length.</param>
        /// <param name="maxLength">The max length.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool IsStringWithAdditionalSymbols(this string value, string addition, int minLength, int maxLength)
        {
            string pattern = string.Format(@"^[a-zA-Z{0}]+$", addition);
            bool isValid = Regex.IsMatch(value, pattern) && value.Length >= minLength && value.Length < maxLength;
            return isValid;
        }
    }
}
