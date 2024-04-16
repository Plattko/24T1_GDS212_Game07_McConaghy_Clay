using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Plattko
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private GameObject pauseMenuUI;
        [SerializeField] private GameObject hotbarUI;

        public void OnPause(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                OpenPauseMenu();
            }
        }

        public void OnResume(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                ClosePauseMenu();
            }
        }
        
        public void OpenPauseMenu()
        {
            hotbarUI.SetActive(false);
            pauseMenuUI.SetActive(true);
            playerInput.SwitchCurrentActionMap("PauseMenu");
            // Stop time
        }

        public void ClosePauseMenu()
        {
            hotbarUI.SetActive(true);
            pauseMenuUI.SetActive(false);
            playerInput.SwitchCurrentActionMap("Player");
            // Resume time
        }
    }
}
