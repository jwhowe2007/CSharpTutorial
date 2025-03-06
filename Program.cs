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
            Console.WriteLine("C# Intro Program");
            Console.WriteLine("Square of 8192: {0}", Basics.Tutorial.Square(8192));

            Basics.Tutorial tutorial = new("Tutorial Class");
            tutorial.DisplayClassVar();

            Basics.Tutorial.BasicDataTypes();
            Basics.Tutorial.NarcisissisticNumbers(5);
            Clients.AlgorithmsClient.TestAlgorithms();
            Clients.InventoryManagerClient.TestInventoryManager();
        }
    }
}
