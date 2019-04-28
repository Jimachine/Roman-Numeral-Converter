using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numeral_Converter
{
    public class RomanConvert
    {
        public static string Solution(int n)
        {
            // An array of values to check against the entered number
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            
            // An array of strings that correspond to the integers in the other array
            string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            // A StringBuilder to allow for appending
            StringBuilder result = new StringBuilder();

            // Cycle through all indexes of the values array
            for (int i = 0; i < values.Length; i++)
            {
                // Check if the integer at index i is higher than the number remaining in the inputted integer
                while (n >= values[i])
                {
                    // Remove the amount at index i from the inputted value, and add the corresponding string at the same index into the variable called result
                    n -= values[i];
                    result.Append(numerals[i]);
                }
            }

            // Convert the StringBuilder into a string to allow the return type to be correct
            string stringResult = result.ToString();

            return stringResult;
        }
    }
}
