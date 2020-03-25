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
            Console.WriteLine("Hello World!");

            Console.WriteLine("Square of 8192: {0}", Basics.Tutorial.Square(8192));

            Basics.Tutorial.DataTypes();
        }
    }
}
