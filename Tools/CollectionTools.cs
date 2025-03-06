using System;
using System.Collections.Generic;
using System.Configuration;

namespace CSharpTutorial.Tools {
    class CollectionTools {
        public static void DisplayObjectList(List<object> collection) {
            Console.WriteLine("[{0}]", string.Join(", ", collection.ToArray()));
        }

        public static void DisplayArray(object[] genericArray) {
            Console.WriteLine("[{0}]", string.Join(", ", genericArray));
        }
    }
}