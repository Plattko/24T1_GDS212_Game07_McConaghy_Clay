using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    public class ItemTest : MonoBehaviour
    {
        public InventoryManager inventoryManager;
        public Item[] items;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                PickupItem(items[1]);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                PickupItem(items[0]);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                GetSelectedItem();
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                UseSelectedItem();
            }
        }

        public void PickupItem(Item item)
        {
            bool wasItemPickedUp = inventoryManager.AddItem(item);

            if (wasItemPickedUp)
            {
                Debug.Log("Item added.");
            }
            else
            {
                Debug.Log("Item not added.");
            }
        }

        public void GetSelectedItem()
        {
            Item item = inventoryManager.GetSelectedItem();
            if (item != null)
            {
                Debug.Log("Received item: " + item);
            }
            else
            {
                Debug.Log("No item received.");
            }
        }

        public void UseSelectedItem() // Does not currently work
        {
            Item item = inventoryManager.GetSelectedItem();
            if (item != null)
            {
                Debug.Log("Used item: " + item);
            }
            else
            {
                Debug.Log("No item to use.");
            }
        }
    }
}
