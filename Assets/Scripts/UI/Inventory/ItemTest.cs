using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    public class ItemTest : MonoBehaviour
    {
        public InventoryManager inventoryManager;
        public Item item;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                PickupItem();
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                GetSelectedItem();
            }
        }

        public void PickupItem()
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
    }
}
