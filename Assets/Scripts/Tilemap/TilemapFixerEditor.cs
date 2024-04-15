using UnityEngine;
using UnityEditor;

namespace Plattko
{
    [CustomEditor(typeof(TilemapFixer))]
    public class TilemapFixerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            var t = target as TilemapFixer;

            if (GUILayout.Button("Refresh Tilemap"))
            {
                t.RefreshAllTilesOnTilemap();
            }
        }
    }
}
