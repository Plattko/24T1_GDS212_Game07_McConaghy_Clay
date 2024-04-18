using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    public interface IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interacted.");
        }
    }
}
