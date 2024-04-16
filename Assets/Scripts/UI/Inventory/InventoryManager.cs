using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    public class InventoryManager : MonoBehaviour
    {
        public InventorySlot[] inventorySlots;
        public GameObject inventoryItemPrefab;

        [Header("Inventory Settings")]
        [SerializeField] private int maxStackCount = 999;
        
        public bool AddItem(Item item)
        {
            for (int i = 0; i < inventorySlots.Length; i++)
            {
                InventorySlot slot = inventorySlots[i];
                InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
                if (itemInSlot != null && itemInSlot.item == item && itemInSlot.stackCount < maxStackCount && itemInSlot.item.isItemStackable == true)
                {
                    itemInSlot.stackCount++;
                    itemInSlot.RefreshCount();
                    return true;
                }
            }

            for (int i = 0; i < inventorySlots.Length; i++)
            {
                InventorySlot slot = inventorySlots[i];
                InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
                if (itemInSlot == null)
                {
                    SpawnNewItem(item, slot);
                    return true;
                }
            }
            return false;
        }

        private void SpawnNewItem(Item item, InventorySlot slot)
        {
            GameObject newItem = Instantiate(inventoryItemPrefab, slot.transform);
            InventoryItem inventoryItem = newItem.GetComponent<InventoryItem>();
            inventoryItem.InitialiseItem(item);
        }
    }
}
