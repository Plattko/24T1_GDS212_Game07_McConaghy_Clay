using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    public class AddItemTest : MonoBehaviour
    {
        public InventoryManager inventoryManager;
        public Item item;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                PickupItem();
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
    }
}
