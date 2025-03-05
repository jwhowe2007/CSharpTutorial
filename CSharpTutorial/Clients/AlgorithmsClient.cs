using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace CSharpTutorial.Clients {
    class AlgorithmsClient {
        public static void TestAlgorithms() {
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