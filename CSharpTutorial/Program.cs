using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.Entity.Core.Metadata.Edm;
using System.Dynamic;

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

            List<HashSet<int>> testSets = [
                [3, 3, 3, 2, 5],
                [2, 1, 5, 7],
                [3, 4, 6, 6],
                [1, 2, 3],
                [5, 3, 9, 8],
                [1]
            ];

            HashSet<int> setA, setB;
            HashSet<int> result = [];

            for (int index = 0; index < testSets.Count; index += 1) {
                setA = testSets[index];
                setB = result.Count == 0 ? testSets[++index] : result;
                result = Basics.Algorithms.SymmetricDifference(setA, setB);

                Console.WriteLine("Symmetric difference between {0} and {1} is: {2}",
                    "[" + string.Join(",", setA.ToImmutableArray<int>()) + "]",
                    "[" + string.Join(",", setB.ToImmutableArray<int>()) + "]",
                    "[" + string.Join(",", result.ToImmutableArray<int>()) + "]"
                );
            }
        }
    }
}
