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
                    Tilemap tilemap = playerController.tileManager.interactableTilemap;
                    Vector3Int tilePos = playerController.tileSelector.GetTilePos(tilemap, playerController);
                    bool isTileTillable = playerController.tileManager.IsTileTillable(tilePos);

                    if (isTileTillable)
                    {
                        Debug.Log("Tile is tillable.");
                        playerController.tileManager.SetTilled(tilePos);
                    }
                    else
                    {
                        Debug.Log("Tile is not tillable.");
                    }

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

        private void UseWateringCan(PlayerController playerController)
        {
            // Refill water or water tile
            InventoryItem item = playerController.inventoryManager.GetSelectedInventoryItem();
            Image waterBarFill = item.waterBarFill;

            Tilemap groundTilemap = playerController.tileManager.groundTilemap;
            Vector3Int groundTilePos = playerController.tileSelector.GetTilePos(groundTilemap, playerController);
            bool isTileWater = playerController.tileManager.IsTileWater(groundTilePos);

            if (isTileWater)
            {
                item.currentWater = waterCapacity;
                waterBarFill.fillAmount = 1;
                Debug.Log("Refilled water.");
            }
            else
            {
                Tilemap interactableTilemap = playerController.tileManager.interactableTilemap;
                Vector3Int interactableTilePos = playerController.tileSelector.GetTilePos(interactableTilemap, playerController);
                bool isTileTilled = playerController.tileManager.IsTileTilled(interactableTilePos);

                if (item.currentWater > 0)
                {
                    if (isTileTilled)
                    {
                        playerController.tileManager.SetWatered(interactableTilePos);
                        Debug.Log("Watered soil.");
                    }

                    item.currentWater--;
                    
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
