using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Plattko
{
    [CreateAssetMenu(fileName = "NewItem", menuName = "Scriptable Object/Create Item", order = 0)]
    public class Item : ScriptableObject
    {
        [Header ("Gameplay Only")]
        public TileBase tile;
        public ItemType itemType;
        public ActionType actionType;

        [Header("UI Only")]
        public bool isItemStackable = true;

        [Header ("UI and Gameplay")]
        public Sprite image;

        public enum ItemType
        {
            Undefined,
            Tool,
            Consumable,
            PlaceableObject
        }

        public enum ActionType
        {
            Undefined,
            Scythe,
            Hoe,
            WateringCan,
            Pickaxe,
            Axe,
            Sword
        }
    }
}
