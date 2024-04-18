using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    [CreateAssetMenu(fileName = "NewFood", menuName = "Scriptable Object/Create Food", order = 4)]
    public class FoodClass : Item
    {
        public override FoodClass GetFood() { return this; }

        public override void UseSecondary(PlayerController playerController)
        {
            Debug.Log("Ate food.");
        }
    }
}
