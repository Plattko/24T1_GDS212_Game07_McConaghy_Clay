using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

namespace Plattko
{
    public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        [Header("UI")]
        [SerializeField] private Image image;
        [SerializeField] private TextMeshProUGUI stackCountText;

        [Header("Watering Can Only")]
        public GameObject waterBar;
        [HideInInspector] public Image waterBarFill;
        [HideInInspector] public int currentWater;

        [HideInInspector] public Transform parentAfterDrag;
        [HideInInspector] public Item item;
        [HideInInspector] public int stackCount = 1;

        public void InitialiseItem(Item newItem)
        {
            item = newItem;
            image.sprite = newItem.image;
            RefreshCount();

            if (item.GetTool())
            {
                ToolClass toolItem = (ToolClass)item;
                if (toolItem.toolType == ToolClass.ToolType.WateringCan)
                {
                    currentWater = toolItem.waterCapacity;
                }
                else
                {
                    waterBar.gameObject.SetActive(false);
                }
            }
            else
            {
                waterBar.gameObject.SetActive(false);
            }
        }

        public void RefreshCount()
        {
            stackCountText.text = stackCount.ToString();
            bool shouldCountDisplay = stackCount > 1;
            stackCountText.gameObject.SetActive(shouldCountDisplay);
        }
        
        public void OnBeginDrag(PointerEventData eventData)
        {
            image.raycastTarget = false;
            parentAfterDrag = transform.parent;
            transform.SetParent(transform.root);
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            image.raycastTarget = true;
            transform.SetParent(parentAfterDrag);
        }
    }
}
