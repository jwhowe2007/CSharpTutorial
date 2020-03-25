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

            for (int i = 0x0530; i < 0x058F; i++)
            {
                char unicodeChar = (char)i;
                Console.WriteLine("Unicode char U+{0:X}: {1}", i, unicodeChar);
            }

            Console.OutputEncoding = System.Text.Encoding.ASCII;
        }
    }
}
