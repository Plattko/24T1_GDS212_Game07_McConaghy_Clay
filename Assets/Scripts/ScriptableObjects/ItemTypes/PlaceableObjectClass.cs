using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    [CreateAssetMenu(fileName = "NewPlaceableObject", menuName = "Scriptable Object/Create Placeable Object", order = 2)]
    public class PlaceableObjectClass : Item
    {
        public override PlaceableObjectClass GetPlaceableObject() { return this; }

        public override void UseSecondary(PlayerController playerController)
        {
            Debug.Log("Placed object.");
        }
    }
}
