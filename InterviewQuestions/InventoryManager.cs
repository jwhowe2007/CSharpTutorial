using System;
using System.Collections.Generic;

namespace CSharpTutorial.InterviewQuestions {
    class InventoryManager(List<List<object>> inventory)
    {
        private readonly List<List<object>> inventory = inventory;

        public void AddInventoryList(List<List<object>> newInventory) {
            // Match inventory entries by name from newInventory and the existing inventory
            foreach (List<object> item in newInventory) {
                AddInventoryEntry(item);
            }

            inventory.Sort((itemA, itemB) => string.Compare((string)itemA[1], (string)itemB[1]));
        }

        public void AddInventoryEntry(List<object> inventoryEntry) {
            // Check to see if the current inventory contains the given entry description and update accordingly
            int itemIndex = inventory.FindIndex(record => record[1] == inventoryEntry[1]);

            if (itemIndex >= 0) {
                inventory[itemIndex][0] = Convert.ToInt32(inventory[itemIndex][0]) + (int)inventoryEntry[0];
            } else {
                inventory.Add(inventoryEntry);
            }
        }

        public void DisplayInventory() {
            Console.WriteLine("=======Inventory List=======");
            foreach(List<object> inventoryEntry in inventory) {
                Tools.CollectionTools.DisplayObjectList(inventoryEntry);
            }
        }
    }
}