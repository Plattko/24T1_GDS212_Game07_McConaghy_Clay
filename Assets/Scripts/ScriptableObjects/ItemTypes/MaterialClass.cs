using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    [CreateAssetMenu(fileName = "NewMaterial", menuName = "Scriptable Object/Create Material", order = 1)]
    public class MaterialClass : Item
    {
        public override MaterialClass GetMaterial() { return this; }
    }
}
