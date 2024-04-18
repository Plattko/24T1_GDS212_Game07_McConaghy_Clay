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
        
        void Start()
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

        public bool IsInteractable(Vector3Int position)
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
        
        public void SetTilled(Vector3Int position)
        {
            interactableTilemap.SetTile(position, tilledTile);
            Color colour = interactableTilemap.GetColor(position);
            colour.a = 1f;
            interactableTilemap.SetColor(position, colour);
        }
    }
}
