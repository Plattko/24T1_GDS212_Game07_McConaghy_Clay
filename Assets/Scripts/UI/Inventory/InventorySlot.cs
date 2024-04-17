using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Plattko
{
    public class InventorySlot : MonoBehaviour, IDropHandler
    {
        public void SelectSlot(Transform slotHighlight)
        {
            slotHighlight.SetParent(transform);
            slotHighlight.localPosition = Vector2.zero;
        }
        
        public void OnDrop(PointerEventData eventData)
        {
            InventoryItem itemInSlot = GetComponentInChildren<InventoryItem>();

            if (itemInSlot == null)
            {
                InventoryItem inventoryItem = eventData.pointerDrag.GetComponent<InventoryItem>();
                inventoryItem.parentAfterDrag = transform;
            }
            else
            {
                Debug.Log("Slot is occupied.");
            }
        }
    }
}
