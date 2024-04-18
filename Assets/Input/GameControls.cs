//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/GameControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Plattko
{
    public partial class @GameControls: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""1d6c73a9-ec9e-48a1-b63d-8bb767f034de"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6b37a641-fce3-4f26-9492-4fa03ab65b0e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""UsePrimary"",
                    ""type"": ""Button"",
                    ""id"": ""5524acff-ece3-44bb-9f2b-a81257522c7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseSecondary"",
                    ""type"": ""Button"",
                    ""id"": ""13eb105b-4b8c-4141-b54e-48ef3fd6acf0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SlowWalk"",
                    ""type"": ""Button"",
                    ""id"": ""add4448b-a942-4ac5-904d-ce95a5aa5729"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""936e1c7e-ea92-4c34-9409-92406a4f541d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar1"",
                    ""type"": ""Button"",
                    ""id"": ""dafe1e9e-074d-40c7-b76f-e92a5ce73c98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar2"",
                    ""type"": ""Button"",
                    ""id"": ""d7fa7c21-3667-476f-9be2-8e286b74eae8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar3"",
                    ""type"": ""Button"",
                    ""id"": ""0840d59d-40c9-4f10-b2f1-19d0e3e38ed7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar4"",
                    ""type"": ""Button"",
                    ""id"": ""c97a148b-c7a4-405a-93a8-95496722ff98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar5"",
                    ""type"": ""Button"",
                    ""id"": ""4e363751-ddb1-4e77-a965-58c844e5b4d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar6"",
                    ""type"": ""Button"",
                    ""id"": ""c9d7b400-4261-4ef3-8338-befa2255b1c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar7"",
                    ""type"": ""Button"",
                    ""id"": ""2a556964-1be9-4b14-aac6-7ea4b8d5026f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar8"",
                    ""type"": ""Button"",
                    ""id"": ""1cfc8c99-61d7-42b8-8883-6d246d6a21cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hotbar9"",
                    ""type"": ""Button"",
                    ""id"": ""f07ccbb4-3c46-48ad-8ff6-8cdbd7a8ce34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HotbarScroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""28fe5608-33fe-4fc7-869b-9d88b1e2c1f2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""0238a315-ad53-4024-aaea-e21d2d0909a1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4aa6f8f1-80b2-4faf-95e8-d6d623c32ee5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""425cfa88-7a62-4e78-a58a-f57db95e7366"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bd9d3327-d285-4ced-a4b1-c19a1dd034ef"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""414cb790-1840-476f-9adf-53ca3289896e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""25b35893-04ec-452b-a3f3-efa125661401"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c0a7075-873d-46fc-9c12-dec961b2712f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""UsePrimary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3001b3a1-a7f1-4278-82b2-17db23772ebd"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""UsePrimary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dab44fd5-8134-4e3b-8a50-3b4aeefc2e22"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""UseSecondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9386c293-cb2e-487c-84e7-d86323a0e12a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""UseSecondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1791c4a0-1e06-442a-bd26-b91206d4d123"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""SlowWalk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""123f1d67-58da-46bb-9984-376ee47813db"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SlowWalk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd7b48d7-0210-4e50-9b88-b5b64319d71a"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b5d36e0-b97f-404a-88c0-a841ae2f34d4"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8aa504b4-d853-4d9b-827c-71d97ef434d4"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Hotbar1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4d4e640-e90f-40a0-9c73-607563274c08"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Hotbar2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c8b63c0-b45a-41e2-9978-51a5e397278e"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Hotbar3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""439241e1-5a15-4085-bb03-60015f3ddd10"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Hotbar4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8199ad1a-983d-439a-85fe-bfe39ccb391d"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Hotbar5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba2b7338-fc43-49bd-b5ca-6728777840ae"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Hotbar6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d95e33e2-8094-4e6f-b221-59f60ff1a883"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Hotbar7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08f7669d-2bb8-4833-bfd8-813781e11922"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Hotbar8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f929b90c-10bd-4cd6-9f5c-a51c5aa095d0"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Hotbar9"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bbaa6ed-c290-4cbb-b57b-0b6ca7900d0d"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""HotbarScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Bumpers"",
                    ""id"": ""b262c6f1-67b1-4ee0-891c-61dd7758d1ef"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HotbarScroll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""27ec94cd-f9fa-4186-9088-ec5cf1404fa4"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""HotbarScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""61356ca8-0fae-4e8e-86b8-46b104ebac36"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""HotbarScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PauseMenu"",
            ""id"": ""15295c33-6ee9-4557-ab99-715d7b8ae24f"",
            ""actions"": [
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""eb4b1537-d523-414e-87ae-94f09e4f9d00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c102c966-d284-4c78-b630-b9e36b98658f"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K&M"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5ff4b15-e603-4749-97c9-6ab068a4a8cd"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""K&M"",
            ""bindingGroup"": ""K&M"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
            m_Player_UsePrimary = m_Player.FindAction("UsePrimary", throwIfNotFound: true);
            m_Player_UseSecondary = m_Player.FindAction("UseSecondary", throwIfNotFound: true);
            m_Player_SlowWalk = m_Player.FindAction("SlowWalk", throwIfNotFound: true);
            m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
            m_Player_Hotbar1 = m_Player.FindAction("Hotbar1", throwIfNotFound: true);
            m_Player_Hotbar2 = m_Player.FindAction("Hotbar2", throwIfNotFound: true);
            m_Player_Hotbar3 = m_Player.FindAction("Hotbar3", throwIfNotFound: true);
            m_Player_Hotbar4 = m_Player.FindAction("Hotbar4", throwIfNotFound: true);
            m_Player_Hotbar5 = m_Player.FindAction("Hotbar5", throwIfNotFound: true);
            m_Player_Hotbar6 = m_Player.FindAction("Hotbar6", throwIfNotFound: true);
            m_Player_Hotbar7 = m_Player.FindAction("Hotbar7", throwIfNotFound: true);
            m_Player_Hotbar8 = m_Player.FindAction("Hotbar8", throwIfNotFound: true);
            m_Player_Hotbar9 = m_Player.FindAction("Hotbar9", throwIfNotFound: true);
            m_Player_HotbarScroll = m_Player.FindAction("HotbarScroll", throwIfNotFound: true);
            // PauseMenu
            m_PauseMenu = asset.FindActionMap("PauseMenu", throwIfNotFound: true);
            m_PauseMenu_Resume = m_PauseMenu.FindAction("Resume", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Player
        private readonly InputActionMap m_Player;
        private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
        private readonly InputAction m_Player_Move;
        private readonly InputAction m_Player_UsePrimary;
        private readonly InputAction m_Player_UseSecondary;
        private readonly InputAction m_Player_SlowWalk;
        private readonly InputAction m_Player_Pause;
        private readonly InputAction m_Player_Hotbar1;
        private readonly InputAction m_Player_Hotbar2;
        private readonly InputAction m_Player_Hotbar3;
        private readonly InputAction m_Player_Hotbar4;
        private readonly InputAction m_Player_Hotbar5;
        private readonly InputAction m_Player_Hotbar6;
        private readonly InputAction m_Player_Hotbar7;
        private readonly InputAction m_Player_Hotbar8;
        private readonly InputAction m_Player_Hotbar9;
        private readonly InputAction m_Player_HotbarScroll;
        public struct PlayerActions
        {
            private @GameControls m_Wrapper;
            public PlayerActions(@GameControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Player_Move;
            public InputAction @UsePrimary => m_Wrapper.m_Player_UsePrimary;
            public InputAction @UseSecondary => m_Wrapper.m_Player_UseSecondary;
            public InputAction @SlowWalk => m_Wrapper.m_Player_SlowWalk;
            public InputAction @Pause => m_Wrapper.m_Player_Pause;
            public InputAction @Hotbar1 => m_Wrapper.m_Player_Hotbar1;
            public InputAction @Hotbar2 => m_Wrapper.m_Player_Hotbar2;
            public InputAction @Hotbar3 => m_Wrapper.m_Player_Hotbar3;
            public InputAction @Hotbar4 => m_Wrapper.m_Player_Hotbar4;
            public InputAction @Hotbar5 => m_Wrapper.m_Player_Hotbar5;
            public InputAction @Hotbar6 => m_Wrapper.m_Player_Hotbar6;
            public InputAction @Hotbar7 => m_Wrapper.m_Player_Hotbar7;
            public InputAction @Hotbar8 => m_Wrapper.m_Player_Hotbar8;
            public InputAction @Hotbar9 => m_Wrapper.m_Player_Hotbar9;
            public InputAction @HotbarScroll => m_Wrapper.m_Player_HotbarScroll;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void AddCallbacks(IPlayerActions instance)
            {
                if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @UsePrimary.started += instance.OnUsePrimary;
                @UsePrimary.performed += instance.OnUsePrimary;
                @UsePrimary.canceled += instance.OnUsePrimary;
                @UseSecondary.started += instance.OnUseSecondary;
                @UseSecondary.performed += instance.OnUseSecondary;
                @UseSecondary.canceled += instance.OnUseSecondary;
                @SlowWalk.started += instance.OnSlowWalk;
                @SlowWalk.performed += instance.OnSlowWalk;
                @SlowWalk.canceled += instance.OnSlowWalk;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Hotbar1.started += instance.OnHotbar1;
                @Hotbar1.performed += instance.OnHotbar1;
                @Hotbar1.canceled += instance.OnHotbar1;
                @Hotbar2.started += instance.OnHotbar2;
                @Hotbar2.performed += instance.OnHotbar2;
                @Hotbar2.canceled += instance.OnHotbar2;
                @Hotbar3.started += instance.OnHotbar3;
                @Hotbar3.performed += instance.OnHotbar3;
                @Hotbar3.canceled += instance.OnHotbar3;
                @Hotbar4.started += instance.OnHotbar4;
                @Hotbar4.performed += instance.OnHotbar4;
                @Hotbar4.canceled += instance.OnHotbar4;
                @Hotbar5.started += instance.OnHotbar5;
                @Hotbar5.performed += instance.OnHotbar5;
                @Hotbar5.canceled += instance.OnHotbar5;
                @Hotbar6.started += instance.OnHotbar6;
                @Hotbar6.performed += instance.OnHotbar6;
                @Hotbar6.canceled += instance.OnHotbar6;
                @Hotbar7.started += instance.OnHotbar7;
                @Hotbar7.performed += instance.OnHotbar7;
                @Hotbar7.canceled += instance.OnHotbar7;
                @Hotbar8.started += instance.OnHotbar8;
                @Hotbar8.performed += instance.OnHotbar8;
                @Hotbar8.canceled += instance.OnHotbar8;
                @Hotbar9.started += instance.OnHotbar9;
                @Hotbar9.performed += instance.OnHotbar9;
                @Hotbar9.canceled += instance.OnHotbar9;
                @HotbarScroll.started += instance.OnHotbarScroll;
                @HotbarScroll.performed += instance.OnHotbarScroll;
                @HotbarScroll.canceled += instance.OnHotbarScroll;
            }

            private void UnregisterCallbacks(IPlayerActions instance)
            {
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
                @UsePrimary.started -= instance.OnUsePrimary;
                @UsePrimary.performed -= instance.OnUsePrimary;
                @UsePrimary.canceled -= instance.OnUsePrimary;
                @UseSecondary.started -= instance.OnUseSecondary;
                @UseSecondary.performed -= instance.OnUseSecondary;
                @UseSecondary.canceled -= instance.OnUseSecondary;
                @SlowWalk.started -= instance.OnSlowWalk;
                @SlowWalk.performed -= instance.OnSlowWalk;
                @SlowWalk.canceled -= instance.OnSlowWalk;
                @Pause.started -= instance.OnPause;
                @Pause.performed -= instance.OnPause;
                @Pause.canceled -= instance.OnPause;
                @Hotbar1.started -= instance.OnHotbar1;
                @Hotbar1.performed -= instance.OnHotbar1;
                @Hotbar1.canceled -= instance.OnHotbar1;
                @Hotbar2.started -= instance.OnHotbar2;
                @Hotbar2.performed -= instance.OnHotbar2;
                @Hotbar2.canceled -= instance.OnHotbar2;
                @Hotbar3.started -= instance.OnHotbar3;
                @Hotbar3.performed -= instance.OnHotbar3;
                @Hotbar3.canceled -= instance.OnHotbar3;
                @Hotbar4.started -= instance.OnHotbar4;
                @Hotbar4.performed -= instance.OnHotbar4;
                @Hotbar4.canceled -= instance.OnHotbar4;
                @Hotbar5.started -= instance.OnHotbar5;
                @Hotbar5.performed -= instance.OnHotbar5;
                @Hotbar5.canceled -= instance.OnHotbar5;
                @Hotbar6.started -= instance.OnHotbar6;
                @Hotbar6.performed -= instance.OnHotbar6;
                @Hotbar6.canceled -= instance.OnHotbar6;
                @Hotbar7.started -= instance.OnHotbar7;
                @Hotbar7.performed -= instance.OnHotbar7;
                @Hotbar7.canceled -= instance.OnHotbar7;
                @Hotbar8.started -= instance.OnHotbar8;
                @Hotbar8.performed -= instance.OnHotbar8;
                @Hotbar8.canceled -= instance.OnHotbar8;
                @Hotbar9.started -= instance.OnHotbar9;
                @Hotbar9.performed -= instance.OnHotbar9;
                @Hotbar9.canceled -= instance.OnHotbar9;
                @HotbarScroll.started -= instance.OnHotbarScroll;
                @HotbarScroll.performed -= instance.OnHotbarScroll;
                @HotbarScroll.canceled -= instance.OnHotbarScroll;
            }

            public void RemoveCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IPlayerActions instance)
            {
                foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public PlayerActions @Player => new PlayerActions(this);

        // PauseMenu
        private readonly InputActionMap m_PauseMenu;
        private List<IPauseMenuActions> m_PauseMenuActionsCallbackInterfaces = new List<IPauseMenuActions>();
        private readonly InputAction m_PauseMenu_Resume;
        public struct PauseMenuActions
        {
            private @GameControls m_Wrapper;
            public PauseMenuActions(@GameControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Resume => m_Wrapper.m_PauseMenu_Resume;
            public InputActionMap Get() { return m_Wrapper.m_PauseMenu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PauseMenuActions set) { return set.Get(); }
            public void AddCallbacks(IPauseMenuActions instance)
            {
                if (instance == null || m_Wrapper.m_PauseMenuActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_PauseMenuActionsCallbackInterfaces.Add(instance);
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
            }

            private void UnregisterCallbacks(IPauseMenuActions instance)
            {
                @Resume.started -= instance.OnResume;
                @Resume.performed -= instance.OnResume;
                @Resume.canceled -= instance.OnResume;
            }

            public void RemoveCallbacks(IPauseMenuActions instance)
            {
                if (m_Wrapper.m_PauseMenuActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IPauseMenuActions instance)
            {
                foreach (var item in m_Wrapper.m_PauseMenuActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_PauseMenuActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public PauseMenuActions @PauseMenu => new PauseMenuActions(this);
        private int m_KMSchemeIndex = -1;
        public InputControlScheme KMScheme
        {
            get
            {
                if (m_KMSchemeIndex == -1) m_KMSchemeIndex = asset.FindControlSchemeIndex("K&M");
                return asset.controlSchemes[m_KMSchemeIndex];
            }
        }
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        public interface IPlayerActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnUsePrimary(InputAction.CallbackContext context);
            void OnUseSecondary(InputAction.CallbackContext context);
            void OnSlowWalk(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
            void OnHotbar1(InputAction.CallbackContext context);
            void OnHotbar2(InputAction.CallbackContext context);
            void OnHotbar3(InputAction.CallbackContext context);
            void OnHotbar4(InputAction.CallbackContext context);
            void OnHotbar5(InputAction.CallbackContext context);
            void OnHotbar6(InputAction.CallbackContext context);
            void OnHotbar7(InputAction.CallbackContext context);
            void OnHotbar8(InputAction.CallbackContext context);
            void OnHotbar9(InputAction.CallbackContext context);
            void OnHotbarScroll(InputAction.CallbackContext context);
        }
        public interface IPauseMenuActions
        {
            void OnResume(InputAction.CallbackContext context);
        }
    }
}
