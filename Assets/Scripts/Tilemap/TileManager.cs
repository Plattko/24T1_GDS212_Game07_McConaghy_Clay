using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Plattko
{
    public class TileManager : MonoBehaviour
    {
        public Tilemap interactableTilemap;

        [Header("Tiles")]
        [SerializeField] private Tile hiddenInteractableTile;
        [SerializeField] private RuleTile tilledTile;

        [Header("Tile Data")]
        [SerializeField] private float wateredTileDuration = 60f;
        private List<Vector3Int> tilledTiles = new List<Vector3Int>();
        private List<Vector3Int> occupiedTiles = new List<Vector3Int>();
        private Dictionary<Vector3Int, float> wateredTileTimers = new Dictionary<Vector3Int, float>();

        [Header("Crop Prefab")]
        public GameObject cropPrefab;

        private void Start()
        {
            foreach (var position in interactableTilemap.cellBounds.allPositionsWithin)
            {
                TileBase tile = interactableTilemap.GetTile(position);
                if (tile != null && tile.name == "InteractableVisible")
                {
                    interactableTilemap.SetTile(position, hiddenInteractableTile);
                }
            }
        }

        private void Update()
        {
            UpdateWateredTileTimers();
        }

        // ---------------------------------
        // TILE UPDATING
        // ---------------------------------
        private void UpdateWateredTileTimers()
        {
            List<Vector3Int> positionsToRemove = new List<Vector3Int>();
            foreach (KeyValuePair<Vector3Int, float> kvp in wateredTileTimers)
            {
                wateredTileTimers[kvp.Key] -= Time.deltaTime;
                if (wateredTileTimers[kvp.Key] <= 0f)
                {
                    positionsToRemove.Add(kvp.Key);
                }
            }
            foreach (Vector3Int position in positionsToRemove)
            {
                RemoveWatered(position);
            }
        }

        // ---------------------------------
        // TILE SETTING
        // ---------------------------------
        public void SetTilled(Vector3Int position)
        {
            interactableTilemap.SetTile(position, tilledTile);
            Color colour = interactableTilemap.GetColor(position);
            colour.a = 1f;
            interactableTilemap.SetColor(position, colour);
            tilledTiles.Add(position);
        }

        public void SetOccupied(Vector3Int position)
        {
            occupiedTiles.Add(position);
        }

        public void SetWatered(Vector3Int position)
        {
            if (!wateredTileTimers.ContainsKey(position))
            {
                wateredTileTimers.Add(position, wateredTileDuration);
            }
            else
            {
                wateredTileTimers[position] = wateredTileDuration;
            }
        }

        // ---------------------------------
        // TILE REMOVING
        // ---------------------------------
        public void RemoveTilled(Vector3Int position)
        {
            interactableTilemap.SetTile(position, hiddenInteractableTile);
            tilledTiles.Remove(position);
        }

        public void RemoveOccupied(Vector3Int position)
        {
            occupiedTiles.Remove(position);
        }

        public void RemoveWatered(Vector3Int position)
        {
            wateredTileTimers.Remove(position);
        }

        // ---------------------------------
        // TILE CHECKS
        // ---------------------------------
        public bool IsTileTillable(Vector3Int position)
        {
            TileBase tile = interactableTilemap.GetTile(position);
            if (tile != null)
            {
                if (tile.name == "Interactable")
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsTileTilled(Vector3Int position)
        {
            return tilledTiles.Contains(position);
        }

        public bool IsTileOccupied(Vector3Int position)
        {
            return occupiedTiles.Contains(position);
        }

        public bool IsTileWatered(Vector3Int position)
        {
            return wateredTileTimers.ContainsKey(position);
        }
    }
}
