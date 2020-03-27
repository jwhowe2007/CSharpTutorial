using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    class Tutorial
    {
        /// <summary>
        /// This is an XML DocBlock that provides more information and context about a
        /// chunk of code for easier readability and may be used to extend documentation
        /// procedures within a given codebase.
        /// </summary>
        /// <param name="x">Integer to be squared</param>
        /// <returns>Square of the given number (x^2)</returns>
        public static Int64 Square(Int64 x)
        {
            return x * x;
        }

        public static void DataTypes()
        {
            // Range: -128 <= x <= 127
            sbyte signedInt = 100;

            // Range: 0 <= x <= 255
            byte color = 0xF0;


            // Shorts
            // Represented by a 2-byte word (16-bits)
            short shortInt = -32768;
            ushort unsignedShort = 65000;

            // Adding a signedInt to a normal integer constant is OK.
            Console.WriteLine("Signed Byte: {0}, {1}", signedInt, signedInt + 100);
            Console.WriteLine("Unsigned Byte: {0}", color);

            // Display the shorts
            Console.WriteLine("Short integers, signed and unsigned: {0}, {1}", shortInt, unsignedShort);

            // Integers
            // Represented by a 4-byte dword (32-bits)
            int foobar = -333330;
            int fooUnsigned = 35959595;
            Console.WriteLine("32-bit ints, signed and unsigned: {0}, {1}", foobar, fooUnsigned);

            // Longs
            // Represented by an 8-byte qword (64-bits)
            long longFoo = -12345678L;
            ulong unsignedLong = 34393939393L;
            Console.WriteLine("64-bit longs, signed and unsigned: {0}, {1}", longFoo, unsignedLong);

            // Double-precision 64-bit IEEE-754 float
            double fooDouble = 123.433301923424829842849028409824;

            // Single-precision 32-bit IEEE-754 float
            float floatNum = 3.1415296568f; // MAKE SURE THE 'f' is appended!

            Console.WriteLine("Floating point nums: {0}, {1}", fooDouble, floatNum);

            // Decimal - 128-bit precision number.
            decimal bigFloat = 16.1234567890123456789123405678901234358787874728947289748927489274m;
            Console.WriteLine("BIIIIG FLOAT! {0}", bigFloat);

            // Boolean - easy peasy
            bool predicate = true;
            bool conclusion = false;
            Console.WriteLine("Inference rule p => q: ~{0} || {1} === {2}", predicate, conclusion, !predicate || conclusion);

            // Unicode text in source code example:
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string unicodeString = "";

            for (int i = 0x1200; i < 0x1210; i++)
            {
                unicodeString += (char)i;                
            }

            UTF8Encoding sampleUTF8 = new UTF8Encoding();
            Byte[] encodedString = sampleUTF8.GetBytes(unicodeString);

            Console.WriteLine(sampleUTF8.GetString(encodedString));
        }

        public void NumbersFun()
        {
            NarcisissisticNumbers(3);
        }

        private void NarcisissisticNumbers(int digits)
        {
            for (long testNumsIndex = (int)Math.Pow(10, digits - 1); testNumsIndex < (int)Math.Pow(10, digits); testNumsIndex++)
            {
                bool isNarcissisticNumber = IsNarcissisticNumber(testNumsIndex) || digits == 0;

                if(isNarcissisticNumber)
                {
                    Console.WriteLine("{0} is a \"Narcissitic\" number.", testNumsIndex);
                }                
            }
        }

        private bool IsNarcissisticNumber(long num)
        {
            // Decompose the number into place digits
            List<int> foobar = DecomposeNumberIntoDigits(num);

            // Get the n-value
            int n = foobar.Count;

            long total = 0;

            foobar.ForEach(digit =>
            {
                total += (long)Math.Pow(digit, n);
            });

            return total == num;
        }

        private List<int> DecomposeNumberIntoDigits(long number)
        {
            long k = 10;
            int places = 0;
            float quotient;
            List<int> decomposedDigits = new List<int>();

            do
            {
                // Get the remainder of number / place                
                quotient = number / k;
                k *= 10;
                places++;
            } while (quotient >= 1);

            long currentNumber = number;

            for (int i = places - 1; i >= 0; i--)
            {                
                /* Decompose the number given by powers of 10, starting with the largest
                 * available digit and ending at the first digit.
                 * 
                 * Example:
                 * 345 will start at place 2, so divide 345 by 10^2 to get 3.45.
                 * Now, we take the integer floor to get the digit 3.
                 * Repeat for the rest of the places (10^1, 10^0)
                 */
                int currentDigit = (int)Math.Floor((double)(currentNumber / Math.Pow(10, i)));
                currentNumber -= (long)currentDigit * (long)Math.Pow(10, i);

                decomposedDigits.Add(currentDigit);
            }

            return decomposedDigits;
        }
    }
}
