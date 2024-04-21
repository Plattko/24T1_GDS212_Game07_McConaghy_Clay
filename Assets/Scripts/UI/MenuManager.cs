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
        [SerializeField] private float hotbarGameplayY = 59f;
        [SerializeField] private float hotbarInventoryY = 615f;

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
            Vector2 anchoredPos = hotbarUI.GetComponent<RectTransform>().anchoredPosition;
            hotbarUI.GetComponent<RectTransform>().anchoredPosition = new Vector2(anchoredPos.x, hotbarInventoryY);
            pauseMenuUI.SetActive(true);
            playerInput.SwitchCurrentActionMap("PauseMenu");
            // Stop time
        }

        public void ClosePauseMenu()
        {
            slotHiglight.SetActive(true);
            hotbarUI.GetComponent<Image>().enabled = true;
            Vector2 anchoredPos = hotbarUI.GetComponent<RectTransform>().anchoredPosition;
            hotbarUI.GetComponent<RectTransform>().anchoredPosition = new Vector2(anchoredPos.x, hotbarGameplayY);
            pauseMenuUI.SetActive(false);
            playerInput.SwitchCurrentActionMap("Player");
            // Resume time
        }
    }
}
