using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpTutorial.Tools {
    class CollectionTools {
        public static void DisplayArrayList(List<Object> collection) {
            Console.WriteLine("[{0}]", string.Join(", ", collection.ToArray()));
        }
    }
}