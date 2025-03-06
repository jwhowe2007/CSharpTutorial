using System;
using System.Collections.Generic;

namespace CSharpTutorial.Clients {
    class InventoryManagerClient {
        public static void TestInventoryManager() {
            // Update Inventory
            List<List<object>> currentInventory = [
                [21, "Bowling Ball"],
                [2, "Dirty Sock"],
                [1, "Hair Pin"],
                [5, "Microphone"]
            ];

            List<List<object>> newInventory = [
                [2, "Hair Pin"],
                [3, "Half-Eaten Apple"],
                [67, "Bowling Ball"],
                [7, "Toothpaste"]
            ];

            InterviewQuestions.InventoryManager invManager = new(currentInventory);

            invManager.DisplayInventory();
            invManager.AddInventoryList(newInventory);
            invManager.DisplayInventory();
        }
    }
}