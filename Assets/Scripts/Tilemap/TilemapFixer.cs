using UnityEngine;
using UnityEngine.Tilemaps;

namespace Plattko
{
    [RequireComponent(typeof(Tilemap))]
    public class TilemapFixer : MonoBehaviour
    {
        public void RefreshAllTilesOnTilemap()
        {
            Tilemap tilemap = GetComponent<Tilemap>();
            tilemap.RefreshAllTiles();
        }
    }
}
