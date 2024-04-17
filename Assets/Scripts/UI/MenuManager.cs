using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Plattko
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private GameObject pauseMenuUI;
        [SerializeField] private GameObject hotbarUI;
        [SerializeField] private GameObject slotHiglight;

        [Header("Hotbar Positions")]
        [SerializeField] private Vector2 hotbarGameplayPosition = new Vector2(960f, 59f);
        [SerializeField] private Vector2 hotbarInventoryPosition = new Vector2(960f, 615f);

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
            slotHiglight.SetActive(false);
            hotbarUI.GetComponent<Image>().enabled = false;
            hotbarUI.transform.position = hotbarInventoryPosition;
            pauseMenuUI.SetActive(true);
            playerInput.SwitchCurrentActionMap("PauseMenu");
            // Stop time
        }

        public void ClosePauseMenu()
        {
            slotHiglight.SetActive(true);
            hotbarUI.GetComponent<Image>().enabled = true;
            hotbarUI.transform.position = hotbarGameplayPosition;
            pauseMenuUI.SetActive(false);
            playerInput.SwitchCurrentActionMap("Player");
            // Resume time
        }
    }
}
