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
            inventoryManager.AddItem(item);
        }
    }
}
