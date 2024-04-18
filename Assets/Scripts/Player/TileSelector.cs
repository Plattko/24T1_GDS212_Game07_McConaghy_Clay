using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Plattko
{
    public class TileSelector : MonoBehaviour
    {
        [SerializeField] private TileManager tileManager;
        private SpriteRenderer spriteRenderer;
        private Vector3 mouseWorldPos;

        [Header("Grid Settings")]
        [SerializeField] private float offset = 0.5f;
        private Vector2 offsetVector;

        private int tileSelectBoxLayer = 6;
        private LayerMask layerMask;

        public bool isTileHighlighted = false;
        public Vector2 displayPos;

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
                isTileHighlighted = true;
                HighlightTile();
            }
            else
            {
                isTileHighlighted = false;
            }
        }

        private void HighlightTile()
        {
            Vector2 gridPos = new Vector2(Mathf.FloorToInt(mouseWorldPos.x), Mathf.FloorToInt(mouseWorldPos.y));
            displayPos = gridPos + offsetVector;
            transform.position = displayPos;
        }

        public Vector3Int GetTilePos(Tilemap tilemap, PlayerController playerController)
        {
            Vector3Int tilePos = Vector3Int.zero;
            
            if (isTileHighlighted)
            {
                tilePos = tilemap.WorldToCell(displayPos);
            }
            else if (!isTileHighlighted)
            {
                Vector2 pivotWorldPos = playerController.spriteRenderer.transform.position;
                Vector2 lastMoveDir = playerController.lastMoveDir;
                Vector3Int playerTilePos = tilemap.WorldToCell(pivotWorldPos);
                tilePos = new Vector3Int(playerTilePos.x + (int)lastMoveDir.x, playerTilePos.y + (int)lastMoveDir.y, playerTilePos.z);
            }
            
            if (tilePos == Vector3Int.zero)
            {
                Debug.LogWarning("Tile Position == Vector3Int.zero.");
            }

            return tilePos;
        }
    }
}
