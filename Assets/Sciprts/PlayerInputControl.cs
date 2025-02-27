//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Sciprts/PlayerInputControl.inputactions
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

public partial class @PlayerInputControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputControl"",
    ""maps"": [
        {
            ""name"": ""Normal"",
            ""id"": ""b604afe0-f6a0-4102-997a-a1b00019b7b0"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""80e37bc2-545c-44ee-8611-eaed5685e813"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3059775e-f282-4ae7-8900-6c084b8c86b8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""d7f019fa-80ae-4476-9f17-65e80c7eae19"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Draw"",
                    ""type"": ""Button"",
                    ""id"": ""b0a6f0dc-3a18-40f5-825f-a1b1acc34287"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""66e01499-dac2-45f4-8275-7af07184d1cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SlowModeActivate"",
                    ""type"": ""Button"",
                    ""id"": ""c6173838-fbd8-4abe-97b5-16ae2b0c1929"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""19b57969-47ec-4cc5-bd63-26f431b8cab0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bfb04470-e6f0-4941-8cdc-b0e0e8e2344a"",
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
                    ""id"": ""7c1764fe-facf-4b79-9507-26eccc15610f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c508510b-ecfb-41cb-84d7-bb1feb86fbcd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""76df168b-2709-4803-9c69-93d87d8105f3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""73446f53-1de7-4094-8515-f8eaa257561c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fe4dd274-8895-462e-9063-c63ffb9bcc5d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bea7098c-6d02-4af4-903c-e0b88bd2b7a7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Draw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6674fe7d-6122-42ba-bd14-a3583f6c3ad4"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Draw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5495a0a1-7343-4f2b-9148-97d10f06df5c"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9057114-fdd2-4ac5-8360-ccc904652532"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlowModeActivate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""7220a6e5-da73-433f-948b-665a7e5ee351"",
            ""actions"": [
                {
                    ""name"": ""SkipDialogue"",
                    ""type"": ""Button"",
                    ""id"": ""f351ffbe-4cee-4536-880a-3296bef241a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""pauseinput"",
                    ""type"": ""Button"",
                    ""id"": ""7b2d1551-2b73-47b5-83b3-70e000e220be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d0dd3ebf-f08e-4f31-95e0-2534f69479ac"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Hold(duration=2.5)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkipDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a9f34ec-3256-41b0-87da-16217181f206"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pauseinput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Normal
        m_Normal = asset.FindActionMap("Normal", throwIfNotFound: true);
        m_Normal_Jump = m_Normal.FindAction("Jump", throwIfNotFound: true);
        m_Normal_Move = m_Normal.FindAction("Move", throwIfNotFound: true);
        m_Normal_Exit = m_Normal.FindAction("Exit", throwIfNotFound: true);
        m_Normal_Draw = m_Normal.FindAction("Draw", throwIfNotFound: true);
        m_Normal_Interact = m_Normal.FindAction("Interact", throwIfNotFound: true);
        m_Normal_SlowModeActivate = m_Normal.FindAction("SlowModeActivate", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_SkipDialogue = m_UI.FindAction("SkipDialogue", throwIfNotFound: true);
        m_UI_pauseinput = m_UI.FindAction("pauseinput", throwIfNotFound: true);
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

    // Normal
    private readonly InputActionMap m_Normal;
    private INormalActions m_NormalActionsCallbackInterface;
    private readonly InputAction m_Normal_Jump;
    private readonly InputAction m_Normal_Move;
    private readonly InputAction m_Normal_Exit;
    private readonly InputAction m_Normal_Draw;
    private readonly InputAction m_Normal_Interact;
    private readonly InputAction m_Normal_SlowModeActivate;
    public struct NormalActions
    {
        private @PlayerInputControl m_Wrapper;
        public NormalActions(@PlayerInputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Normal_Jump;
        public InputAction @Move => m_Wrapper.m_Normal_Move;
        public InputAction @Exit => m_Wrapper.m_Normal_Exit;
        public InputAction @Draw => m_Wrapper.m_Normal_Draw;
        public InputAction @Interact => m_Wrapper.m_Normal_Interact;
        public InputAction @SlowModeActivate => m_Wrapper.m_Normal_SlowModeActivate;
        public InputActionMap Get() { return m_Wrapper.m_Normal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NormalActions set) { return set.Get(); }
        public void SetCallbacks(INormalActions instance)
        {
            if (m_Wrapper.m_NormalActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnMove;
                @Exit.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnExit;
                @Draw.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnDraw;
                @Draw.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnDraw;
                @Draw.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnDraw;
                @Interact.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnInteract;
                @SlowModeActivate.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnSlowModeActivate;
                @SlowModeActivate.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnSlowModeActivate;
                @SlowModeActivate.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnSlowModeActivate;
            }
            m_Wrapper.m_NormalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
                @Draw.started += instance.OnDraw;
                @Draw.performed += instance.OnDraw;
                @Draw.canceled += instance.OnDraw;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @SlowModeActivate.started += instance.OnSlowModeActivate;
                @SlowModeActivate.performed += instance.OnSlowModeActivate;
                @SlowModeActivate.canceled += instance.OnSlowModeActivate;
            }
        }
    }
    public NormalActions @Normal => new NormalActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_SkipDialogue;
    private readonly InputAction m_UI_pauseinput;
    public struct UIActions
    {
        private @PlayerInputControl m_Wrapper;
        public UIActions(@PlayerInputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @SkipDialogue => m_Wrapper.m_UI_SkipDialogue;
        public InputAction @pauseinput => m_Wrapper.m_UI_pauseinput;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @SkipDialogue.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSkipDialogue;
                @SkipDialogue.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSkipDialogue;
                @SkipDialogue.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSkipDialogue;
                @pauseinput.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPauseinput;
                @pauseinput.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPauseinput;
                @pauseinput.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPauseinput;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SkipDialogue.started += instance.OnSkipDialogue;
                @SkipDialogue.performed += instance.OnSkipDialogue;
                @SkipDialogue.canceled += instance.OnSkipDialogue;
                @pauseinput.started += instance.OnPauseinput;
                @pauseinput.performed += instance.OnPauseinput;
                @pauseinput.canceled += instance.OnPauseinput;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface INormalActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
        void OnDraw(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSlowModeActivate(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnSkipDialogue(InputAction.CallbackContext context);
        void OnPauseinput(InputAction.CallbackContext context);
    }
}
