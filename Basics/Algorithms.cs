using System.Collections.Generic;

namespace CSharpTutorial.Basics {
    class Algorithms {
        public static HashSet<int> SymmetricDifference(HashSet<int> firstSet, HashSet<int> secondSet) {
            HashSet<int> symDiff = [];

            foreach(int datum in firstSet) {
                if (!secondSet.Contains(datum)) {
                    symDiff.Add(datum);
                }
            }

            foreach(int datum in secondSet) {
                if (!firstSet.Contains(datum)) {
                    symDiff.Add(datum);
                }
            }

            return symDiff;
        }
    }
}
