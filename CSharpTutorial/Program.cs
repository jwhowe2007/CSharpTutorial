using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single line comment

            /* 
             * Comment line 1
             * Comment line 2
             */

            ///
            /// Heredoc-style comment
            /// Everything in these blocks is treated as one long literal
            /// broken up into multiple lines, and functions much like the delimited block style shown above.
            /// This, however, can be used to specify special capabilities and flags for the compiler and any other tool that
            /// needs to use this information as metadata.
            /// 
            Console.WriteLine("C# Intro Program");
            Console.WriteLine("Square of 8192: {0}", Basics.Tutorial.Square(8192));

            Basics.Tutorial tutorial = new();
            Basics.Tutorial.BasicDataTypes();
            tutorial.NumbersFun();
        }
    }
}
