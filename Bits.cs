using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HideAndSeek
{
    public class Bits
    {
        /// <summary>
        /// Get the maximum value obtainaible by n bits (n ones)
        /// if n = 5 for example we will have 11111 and thus 31
        /// </summary>
        /// <param name="n"> The number of bits available</param>
        /// <returns> The value calculated</returns>
        public static int GetMaxForNBits(int n)
        {
            int max = 0;
            int twopow = 1;
            for(int i = 0; i<n;i++)
            {
                max += twopow;
                twopow += twopow;
            }
            return max;
        }

        /// <summary>
        /// Set the n least significants bits to 0
        /// </summary>
        /// <param name="to_reset"> The integer to reset</param>
        /// <param name="n"> The number of bits to reset (Check subject for n negative)</param>
        public static void ResetLeastSignificantBits(ref int to_reset, int n)
        {
            to_reset = to_reset >> n;
            to_reset = to_reset << n;
        }

        /// <summary>
        /// Gets the n least significants bits of to_get
        /// </summary>
        /// <param name="to_get"> The variable to get the bits</param>
        /// <param name="n"> The number of bits to get</param>
        /// <returns> The least significants bits of to_get</returns>
        public static int GetLeastSignificantBits(int to_get, int n)
        {
            int minus = to_get;
            ResetLeastSignificantBits(ref minus, n);
            return to_get - minus;
        }

        /// <summary>
        /// Set the least significant bits to the least significant bits of value
        /// </summary>
        /// <param name="to_set"> The integer to modify</param>
        /// <param name="val"> The integer from which we will take the bits to set</param>
        /// <param name="n"> The number of bits to set</param>
        public static void SetLeastSignificantBits(ref int to_set, int val, int n)
        {
            ResetLeastSignificantBits(ref to_set, n);
            to_set = to_set + GetLeastSignificantBits(val, n);
        }
    }
}
