using System;
using System.Collections.Generic;

namespace CSharpTutorial.InterviewQuestions {
    class InventoryManager(List<List<Object>> inventory)
    {
        private List<List<Object>> inventory = inventory;

        public void AddInventoryList(List<List<Object>> newInventory) {
            // Match inventory entries by name from newInventory and the existing inventory
            foreach (List<Object> item in newInventory) {
                this.AddInventoryEntry(item);
            }

            this.inventory.Sort((itemA, itemB) => String.Compare((string)itemA[1], (string)itemB[1]));
        }

        public void AddInventoryEntry(List<Object> inventoryEntry) {
            // Check to see if the current inventory contains the given entry description and update accordingly
            int itemIndex = this.inventory.FindIndex(record => record[1] == inventoryEntry[1]);

            if (itemIndex >= 0) {
                this.inventory[itemIndex][0] = Convert.ToInt32(this.inventory[itemIndex][0]) + (int)inventoryEntry[0];
            } else {
                this.inventory.Add(inventoryEntry);
            }
        }

        public void DisplayInventory() {
            Console.WriteLine("=======Inventory List==========");
            foreach(List<Object> inventoryEntry in this.inventory) {
                Tools.CollectionTools.DisplayArrayList(inventoryEntry);
            }
        }
    }
}