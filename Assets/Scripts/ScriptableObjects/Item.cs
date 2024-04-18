using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Plattko
{
    public class Item : ScriptableObject
    {
        [Header("UI Only")]
        public bool isItemStackable = true;

        [Header ("UI and Gameplay")]
        public Sprite image;
        
        public virtual void UsePrimary(PlayerController playerController)
        {

        }

        public virtual void UseSecondary(PlayerController playerController)
        {

        }

        public virtual ToolClass GetTool() { return null; }
        public virtual MaterialClass GetMaterial() { return null ; }
        public virtual PlaceableObjectClass GetPlaceableObject() { return null; }
        public virtual SeedClass GetSeed() { return null; }
        public virtual FoodClass GetFood() { return null; }
    }
}
