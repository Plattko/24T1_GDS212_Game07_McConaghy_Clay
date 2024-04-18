using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    public class Crop : MonoBehaviour
    {
        private TileManager tileManager;
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private Sprite deadSprite;

        private Item cropItem;

        private bool canGrow = false;
        private float timeToGrow;
        private float growthTimer = 0f;

        private float growthStageDuration;
        private float growthStageTimer = 0f;
        private int growthStageIndex = 0;

        private float timeToDie = 180f;
        private float deathTimer;

        private Sprite[] growthProgressSprites;
        private Sprite readyToHarvestSprite;

        Vector3Int tilePos;

        private bool isReadyToHarvest = false;
        private bool isDead = false;

        void Update()
        {
            if (canGrow)
            {
                GrowCrop();
            }
        }

        public void InitialiseCrop(Item crop, float timeToGrow, Sprite[] progressSprites, Sprite harvestSprite, Vector3Int tilePos, TileManager tileManager)
        {
            cropItem = crop;
            this.timeToGrow = timeToGrow;
            growthProgressSprites = progressSprites;
            readyToHarvestSprite = harvestSprite;
            this.tilePos = tilePos;
            this.tileManager = tileManager;

            spriteRenderer.sprite = this.growthProgressSprites[0];
            int growthStageCount = progressSprites.Length;
            growthStageDuration = timeToGrow / growthStageCount;

            canGrow = true;
        }

        private void GrowCrop()
        {
            if (tileManager.IsTileWatered(tilePos))
            {
                if (deathTimer > 0f)
                {
                    deathTimer = 0f;
                }
                
                growthTimer += Time.deltaTime;
                growthStageTimer += Time.deltaTime;

                if (growthTimer >= timeToGrow)
                {
                    canGrow = false;
                    isReadyToHarvest = true;
                    spriteRenderer.sprite = readyToHarvestSprite;
                }

                if (growthStageTimer >= growthStageDuration)
                {
                    growthStageTimer = 0f;
                    growthStageIndex++;
                    spriteRenderer.sprite = growthProgressSprites[growthStageIndex];
                    if (growthStageIndex > 0 && growthStageIndex < 2)
                    {
                        spriteRenderer.sortingOrder = 1;
                    }
                }
            }
            else
            {
                deathTimer += Time.deltaTime;

                if (deathTimer >= timeToDie)
                {
                    canGrow = false;
                    isDead = true;
                    spriteRenderer.sprite = deadSprite;
                }
            }
        }
    }
}
