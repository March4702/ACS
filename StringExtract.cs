using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS
{
    internal class StringExtract
    {
        /// <summary>
        /// Extracts substrings from the input text based on a specified delimiter.
        /// </summary>
        /// <param name="input">The full string to split.</param>
        /// <param name="delimiter">The delimiter string to split by.</param>
        /// <returns>List of substrings (empty list if no match).</returns>

        public static List<string> ExtractSubstrings(string input, string delimiter)
        {
            var results = new List<string>();

            // Validate inputs
            if (string.IsNullOrEmpty(input))
                return results; // Return empty list if input is null or empty

            if (string.IsNullOrEmpty(delimiter))
                throw new ArgumentException("Delimiter cannot be null or empty.", nameof(delimiter));

            // Split using the specified delimiter
            string[] parts = input.Split(new string[] { delimiter }, StringSplitOptions.None);

            foreach (var part in parts)
            {
                string trimmed = part.Trim();
                if (!string.IsNullOrEmpty(trimmed))
                {
                    results.Add(trimmed);
                }
            }

            return results;
        }
    }
}