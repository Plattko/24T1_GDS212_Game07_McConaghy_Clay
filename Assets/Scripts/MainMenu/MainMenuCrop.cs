using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    public class MainMenuCrop : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer;

        [SerializeField] private float timeToGrow;
        private float growthTimer = 0f;

        private float growthStageDuration;
        private float growthStageTimer = 0f;
        private int growthStageIndex = 0;

        [SerializeField] private Sprite[] growthProgressSprites;
        [SerializeField] private Sprite readyToHarvestSprite;

        private bool canGrow = false;

        private void Start()
        {
            timeToGrow = Random.Range(timeToGrow - 3f, timeToGrow + 3f);
            int growthStageCount = growthProgressSprites.Length;
            growthStageDuration = timeToGrow / growthStageCount;
            canGrow = true;
        }

        private void Update()
        {
            if (canGrow)
            {
                GrowCrop();
            }
        }

        private void GrowCrop()
        {
            growthTimer += Time.deltaTime;
            growthStageTimer += Time.deltaTime;

            if (growthTimer >= timeToGrow)
            {
                canGrow = false;
                spriteRenderer.sprite = readyToHarvestSprite;
            }
            else if (growthStageTimer >= growthStageDuration)
            {
                growthStageTimer = 0f;
                growthStageIndex++;
                spriteRenderer.sprite = growthProgressSprites[growthStageIndex];
            }
        }
    }
}
