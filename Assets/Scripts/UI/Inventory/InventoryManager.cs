using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Plattko
{
    public class InventoryManager : MonoBehaviour
    {
        public InventorySlot[] inventorySlots;
        public GameObject inventoryItemPrefab;

        [Header("Inventory Settings")]
        [SerializeField] private int maxStackCount = 999;

        [Header("Hotbar Settings")]
        [SerializeField] private Transform slotHighlight;
        [SerializeField] private int maxSlotIndex = 8;
        private int currentSlotIndex = 0;
        private float scrollInput;

        private void Start()
        {
            ChangeSelectedSlot(currentSlotIndex);
        }

        private void Update()
        {
            if (scrollInput != 0)
            {
                ScrollSlot(Mathf.RoundToInt(scrollInput / 120f));
            }
        }

        private void ChangeSelectedSlot(int newSlotIndex)
        {
            //inventorySlots[currentSlotIndex].DeselectSlot(); - If necessary
            inventorySlots[newSlotIndex].SelectSlot(slotHighlight);
            currentSlotIndex = newSlotIndex;
        }

        private void ScrollSlot(int direction)
        {
            currentSlotIndex += direction;
            
            if (currentSlotIndex > maxSlotIndex)
            {
                currentSlotIndex = 0;
            }

            if (currentSlotIndex < 0)
            {
                currentSlotIndex = maxSlotIndex;
            }

            ChangeSelectedSlot(currentSlotIndex);
        }
        
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

        public Item GetSelectedItem(bool isItemConsumable)
        {
            InventorySlot slot = inventorySlots[currentSlotIndex];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot != null)
            {
                Item item = itemInSlot.item;
                if (isItemConsumable)
                {
                    itemInSlot.stackCount--;
                    if (itemInSlot.stackCount <= 0)
                    {
                        Destroy(itemInSlot.gameObject);
                    }
                    else
                    {
                        itemInSlot.RefreshCount();
                    }
                }
                return item;
            }

            return null;
        }

        // ---------------------------------
        // INPUT CHECKS
        // ---------------------------------
        public void OnHotbar1(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                ChangeSelectedSlot(0);
            }
        }

        public void OnHotbar2(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                ChangeSelectedSlot(1);
            }
        }

        public void OnHotbar3(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                ChangeSelectedSlot(2);
            }
        }

        public void OnHotbar4(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                ChangeSelectedSlot(3);
            }
        }

        public void OnHotbar5(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                ChangeSelectedSlot(4);
            }
        }

        public void OnHotbar6(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                ChangeSelectedSlot(5);
            }
        }

        public void OnHotbar7(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                ChangeSelectedSlot(6);
            }
        }

        public void OnHotbar8(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                ChangeSelectedSlot(7);
            }
        }

        public void OnHotbar9(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                ChangeSelectedSlot(8);
            }
        }

        public void OnHotbarScroll(InputAction.CallbackContext context)
        {
            scrollInput = context.ReadValue<float>();
        }
    }
}
