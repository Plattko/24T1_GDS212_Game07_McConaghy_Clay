using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    public class StartingItems : MonoBehaviour
    {
        [SerializeField] InventoryManager inventoryManager;

        [Header("Starting Items")]
        [SerializeField] Item[] startingItems;
        // Items to include:
        // Hoe
        // Watering Can
        // Axe
        // Potato Seeds x15

        [SerializeField] private int starterSeedCount = 15;
        
        void Start()
        {
            GivePlayerStartingItems();
        }

        private void GivePlayerStartingItems()
        {
            foreach (Item item in startingItems)
            {
                if (item.itemType == Item.ItemType.Seed)
                {
                    for (int i = 0; i < starterSeedCount; i++)
                    {
                        inventoryManager.AddItem(item);
                    }
                }
                else
                {
                    inventoryManager.AddItem(item);
                }
            }
        }
    }
}
