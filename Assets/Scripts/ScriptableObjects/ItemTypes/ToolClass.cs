using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

namespace Plattko
{
    [CreateAssetMenu(fileName = "NewTool", menuName = "Scriptable Object/Create Tool", order = 0)]
    public class ToolClass : Item
    {
        public override ToolClass GetTool() { return this; }

        public ToolType toolType;

        public enum ToolType
        {
            Undefined,
            Scythe,
            Hoe,
            WateringCan,
            Pickaxe,
            Axe,
            Sword
        }

        [Header("Watering Can Only")]
        public int waterCapacity = 25;

        public override void UsePrimary(PlayerController playerController)
        {
            base.UsePrimary(playerController);

            switch (toolType)
            {
                case ToolType.Scythe:
                    Debug.Log("Used scythe.");
                    break;

                case ToolType.Hoe:
                    Debug.Log("Used hoe.");
                    UseHoe(playerController);
                    break;

                case ToolType.WateringCan:
                    Debug.Log("Used watering can.");
                    UseWateringCan(playerController);
                    break;

                case ToolType.Pickaxe:
                    Debug.Log("Used pickaxe.");
                    break;

                case ToolType.Axe:
                    Debug.Log("Used axe.");
                    break;

                case ToolType.Sword:
                    Debug.Log("Attacked with sword.");
                    break;

                default:
                    break;
            }
        }

        public override void UseSecondary(PlayerController playerController)
        {
            switch (toolType)
            {
                case ToolType.Sword:
                    Debug.Log("Blocked with sword.");
                    break;

                default:
                    break;
            }
        }

        private void UseHoe(PlayerController playerController)
        {
            TileManager tileManager = playerController.tileManager;
            TileSelector tileSelector = playerController.tileSelector;

            Tilemap tilemap = tileManager.interactableTilemap;
            Vector3Int tilePos = tileSelector.GetTilePos(tilemap, playerController);
            bool isTileTillable = tileManager.IsTileTillable(tilePos);

            if (isTileTillable)
            {
                Debug.Log("Tile is tillable.");
                tileManager.SetTilled(tilePos);
            }
            else
            {
                Debug.Log("Tile is not tillable.");
            }
        }

        private void UseWateringCan(PlayerController playerController)
        {
            // Refill water or water tile
            TileManager tileManager = playerController.tileManager;
            TileSelector tileSelector = playerController.tileSelector;
            InventoryItem item = playerController.inventoryManager.GetSelectedInventoryItem();
            Image waterBarFill = item.waterBarFill;

            Tilemap tilemap = tileManager.interactableTilemap;
            Vector3Int tilePos = tileSelector.GetTilePos(tilemap, playerController);
            bool isTileWater = tileManager.IsTileWater(tilePos);
            bool isTileTilled = tileManager.IsTileTilled(tilePos);

            if (isTileWater)
            {
                item.currentWater = waterCapacity;
                waterBarFill.fillAmount = 1;
                Debug.Log("Refilled water.");
            }
            else
            {
                if (item.currentWater > 0)
                {
                    item.currentWater--;

                    if (isTileTilled)
                    {
                        tileManager.SetWatered(tilePos);
                        Debug.Log("Watered soil.");
                    }
                    
                    if (item.currentWater <= 0)
                    {
                        waterBarFill.fillAmount = 0;
                    }
                    else
                    {
                        float fillAmount = (float)item.currentWater / waterCapacity;
                        waterBarFill.fillAmount = fillAmount;
                    }
                }
                else
                {
                    Debug.Log("No water.");
                }
            }
            Debug.Log("Current water: " + item.currentWater + "/" + waterCapacity);
        }
    }
}
