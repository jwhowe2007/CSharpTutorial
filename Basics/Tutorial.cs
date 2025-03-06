using System;

namespace CSharpTutorial.Basics
{
    class Tutorial(string newClassVarValue = "")
    {
        private readonly string classVar = newClassVarValue;

        public void DisplayClassVar() {
            Console.WriteLine(this.classVar);
        }

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

        public static void BasicDataTypes()
        {
            // Range: -128 <= x <= 127
            sbyte signedByte = sbyte.MinValue;

            // Range: 0 <= x <= 255
            byte color = 0xF0;

            // Shorts
            // Represented by a 2-byte word (16-bits)
            short shortInt = short.MinValue;
            ushort unsignedShort = ushort.MaxValue;

            // Adding a signedInt to a normal integer constant is OK.
            Console.WriteLine("Signed Byte: {0}, {1}", signedByte, signedByte + 0x64);
            Console.WriteLine("Unsigned Byte: 0x{0:X}", color);

            // Display the shorts
            Console.WriteLine("Short integers, signed and unsigned: {0}, {1}", shortInt, unsignedShort);

            // Integers
            // Represented by a 4-byte dword (32-bits)
            int foobar = int.MinValue;
            uint fooUnsigned = uint.MaxValue;
            Console.WriteLine("32-bit ints, signed and unsigned: {0}, {1}", foobar, fooUnsigned);

            // Longs
            // Represented by an 8-byte qword (64-bits)
            long longFoo = long.MinValue;
            ulong unsignedLong = ulong.MaxValue;
            Console.WriteLine("64-bit longs, signed and unsigned: {0}, {1}", longFoo, unsignedLong);

            // Double-precision 64-bit IEEE-754 float
            double fooDouble = 123.433301923424829842849028409824d;

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
            string unicodeString = "";

            for (int i = 0x0400; i < 0x04FF; i++)
            {
                unicodeString += (char)i + " ";
            }

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(unicodeString);

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("\nHH:mm:ss, dd MMM yyyy\n"));

            // Arrays - useful when you have a set of data that you don't change very often, if at all.
            int[] intArray = [1, 1, 2, 3, 5, 8, 13, 21, 34, 55];
        }

        public static void NarcisissisticNumbers(int digits) {
            ulong testNumsRangeEnd = (ulong)Math.Pow(10, digits);

            for (ulong testNumsIndex = 1; testNumsIndex < testNumsRangeEnd; testNumsIndex++) {
                if (IsNarcissisticNumber(testNumsIndex)) {
                    Console.WriteLine("{0} is a \"Narcissistic\" number.", testNumsIndex);
                }
            }
        }

        public static bool IsNarcissisticNumber(ulong num) {
            // Decompose the number into place digits
            /* Narcisisstic numbers are numbers that are the sum of the digits of a number raised to the power of the number of the digits.
             * For example, testing a number 123 yields the following:
             * 1^3 + 2^3 + 3^3 = 1 + 8 + 27 = 36, which does not equal 123, so it's not a narcisisstic number.
             * However, 153 yields:
             * 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153 which is a narcisisstic number.
             */
            ulong decompNum = num;
            int numDigits = CountDigits(num);
            ulong total = 0;

            do {
                ulong decompDigit = (ulong)(decompNum % 10);
                decompNum = (ulong)(decompNum - decompDigit) / 10;
                total += (ulong)Math.Pow((double)decompDigit, (double)numDigits);
            } while(decompNum > 0);

            return total == num;
        }

        /// <summary>
        /// Count the number of digits in a base 10 long int by repeatedly taking the modulus of number % 10
        /// </summary>
        /// <param name="number">Long integer number</param>
        /// <returns>Number of digits in a given number</returns>
        private static int CountDigits(ulong number) {
            int digitCount = 0;
            ulong quotient = number;

            do {
                digitCount++;
                quotient = (ulong)(quotient / 10);
            } while (quotient >= 1);

            return digitCount;
        }
    }
}
