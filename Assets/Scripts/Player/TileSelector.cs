using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    public class TileSelector : MonoBehaviour
    {
        [SerializeField] private Transform playerTransform;
        private SpriteRenderer spriteRenderer;
        private Vector3 mouseWorldPos;

        [Header("Grid Settings")]
        [SerializeField] private float offset = 0.5f;
        private Vector2 offsetVector;

        private int tileSelectBoxLayer = 6;
        private LayerMask layerMask;

        void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            offsetVector = new Vector2(offset, offset);
            layerMask = 1 << tileSelectBoxLayer;
        }

        void Update()
        {
            mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0f;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            bool isMouseInRange = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, layerMask);

            if (isMouseInRange && !spriteRenderer.enabled)
            {
                spriteRenderer.enabled = true;
            }
            else if (!isMouseInRange && spriteRenderer.enabled)
            {
                spriteRenderer.enabled = false;
            }

            if (spriteRenderer.enabled)
            {
                HighlightTile();
            }
        }

        private void HighlightTile()
        {
            Vector2 gridPos = new Vector2(Mathf.FloorToInt(mouseWorldPos.x), Mathf.FloorToInt(mouseWorldPos.y));
            Vector2 displayPos = gridPos + offsetVector;
            transform.position = displayPos;
        }
    }
}
