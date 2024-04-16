using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Plattko
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject pauseMenuUI;
        [SerializeField] private GameObject hotbarUI;

        public void OpenPauseMenu()
        {
            hotbarUI.SetActive(false);
            pauseMenuUI.SetActive(true);
            // Stop time
            // Swap to PauseMenu action map
        }

        public void ClosePauseMenu()
        {
            hotbarUI.SetActive(true);
            pauseMenuUI.SetActive(false);
            // Resume time
            // Swap to Player action map
        }
    }
}
