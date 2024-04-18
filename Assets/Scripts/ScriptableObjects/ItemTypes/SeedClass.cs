using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Plattko
{
    [CreateAssetMenu(fileName = "NewSeed", menuName = "Scriptable Object/Create Seed", order = 3)]
    public class SeedClass : Item
    {
        [Header("Crop")]
        public Item cropItem;

        [Header("Grow Time")]
        public float timeToGrow;

        [Header("Sprites")]
        public Sprite[] growProgressSprites;
        public Sprite readyToHarvestSprite;
        public Vector2 spawnOffset;
        
        public override SeedClass GetSeed() { return this; }

        public override void UsePrimary(PlayerController playerController)
        {
            Debug.Log("Planted seed.");

            Tilemap tilemap = playerController.tileManager.interactableTilemap;
            Vector3Int tilePos = playerController.tileSelector.GetTilePos(tilemap, playerController);

            if (playerController.tileManager.IsTileTilled(tilePos) && !playerController.tileManager.IsTileOccupied(tilePos))
            {
                PlantCrop(tilePos, playerController);
            }
        }

        private void PlantCrop(Vector3Int tilePos, PlayerController playerController)
        {
            Vector2 spawnPos = new Vector2(tilePos.x + spawnOffset.x, tilePos.y + spawnOffset.y);
            playerController.tileManager.SetOccupied(tilePos);
            Crop crop = Instantiate(playerController.tileManager.cropPrefab, spawnPos, Quaternion.identity).GetComponent<Crop>();
            crop.InitialiseCrop(cropItem, timeToGrow, growProgressSprites, readyToHarvestSprite, tilePos, playerController.tileManager);
            playerController.inventoryManager.ConsumeItem();
        }
    }
}
