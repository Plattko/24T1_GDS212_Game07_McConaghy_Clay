using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    [CreateAssetMenu(fileName = "NewSeed", menuName = "Scriptable Object/Create Seed", order = 3)]
    public class SeedClass : Item
    {
        public override SeedClass GetSeed() { return this; }

        public override void UseSecondary(PlayerController playerController)
        {
            Debug.Log("Planted seed.");
        }
    }
}
