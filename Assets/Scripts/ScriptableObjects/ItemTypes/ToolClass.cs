using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

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
                    bool isTileTillable = playerController.tileManager.IsInteractable(tilePos);

                    if (isTileTillable)
                    {
                        Debug.Log("Tile is tillable.");
                        playerController.tileManager.SetTilled(tilePos);
                    }
                    else
                    {
                        Debug.Log("Tile is not tillable.");
                    }

                    //if (isTileHighlighted)
                    //{
                    //    Vector3Int tilePos = tilemap.WorldToCell(playerController.tileSelector.displayPos);
                    //    bool isTileTillable = playerController.tileManager.IsInteractable(tilePos);

                    //    if (isTileTillable)
                    //    {
                    //        Debug.Log("Tile is tillable.");
                    //        playerController.tileManager.SetTilled(tilePos);
                    //    }
                    //    else
                    //    {
                    //        Debug.Log("Tile is not tillable.");
                    //    }
                    //}
                    //else if (!isTileHighlighted)
                    //{
                    //    Vector2 pivotWorldPos = playerController.spriteRenderer.transform.position;
                    //    Vector2 lastMoveDir = playerController.lastMoveDir;
                    //    Vector3Int playerTilePos = tilemap.WorldToCell(pivotWorldPos);
                    //    Vector3Int tilePos = new Vector3Int(playerTilePos.x + (int)lastMoveDir.x, playerTilePos.y + (int)lastMoveDir.y, playerTilePos.z);

                    //    bool isTileTillable = playerController.tileManager.IsInteractable(tilePos);
                    //    if (isTileTillable)
                    //    {
                    //        Debug.Log("Tile is tillable.");
                    //        playerController.tileManager.SetTilled(tilePos);
                    //    }
                    //    else
                    //    {
                    //        Debug.Log("Tile is not tillable.");
                    //    }
                    //}

                    break;

                case ToolType.WateringCan:
                    Debug.Log("Used watering can.");
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
    }
}
