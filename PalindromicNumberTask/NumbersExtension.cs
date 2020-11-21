﻿using System;

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} cannot be less than zero");
            }

            static int Reverse(int num)
            {
                int result = 0;
                while (num > 0)
                {
                    result = (result * 10) + (num % 10);
                    num /= 10;
                }

                return result;
            }

            return number == Reverse(number);
        }
    }
}
