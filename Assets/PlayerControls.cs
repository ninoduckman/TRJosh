//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""CamMovement"",
            ""id"": ""c3e38a1b-168c-4636-bcbf-7fdf8901f94c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6bce0d9d-67c4-4678-8c84-6ebb3baf6de3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MousePos"",
                    ""type"": ""Value"",
                    ""id"": ""d2f4d9cb-00a9-46c2-bae0-ed80429314de"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""5dabe48b-a0c7-43a0-9bd8-3fad8484ce9d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""95fd3f16-3f42-4a39-b410-05cd1a36747c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""wasd"",
                    ""id"": ""b23235bb-3f99-49ae-ba95-4ce6e15ee27d"",
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
                    ""id"": ""2160cd2b-8ccf-43db-8c87-1db46edc4b5b"",
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
                    ""id"": ""56929c30-d9b7-4658-b904-dd85d93e2774"",
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
                    ""id"": ""fb131888-ed4b-4692-be88-4499bba0a488"",
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
                    ""id"": ""a6ef4542-9b73-47fe-af14-44181e93890d"",
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
                    ""id"": ""424c7e41-cd95-4e31-ac4e-0ce8c22b9772"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f48ae20-026d-46dd-91c2-8f35d08fd1c4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfb0145f-6297-46d2-9716-2f3d2c57bacb"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""+-"",
                    ""id"": ""411baa7f-2205-47ac-ab25-11d3fe969966"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5ea66113-8d03-4b72-9a19-8e009a77acf7"",
                    ""path"": ""<Keyboard>/numpadMinus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""98a172dd-fcd0-459f-9786-b2bc4cf9bff4"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Other"",
            ""id"": ""fe9eaae6-2cc1-42e2-911f-54649f532d1e"",
            ""actions"": [
                {
                    ""name"": ""Dark"",
                    ""type"": ""Button"",
                    ""id"": ""0bfcfe46-12cc-433d-8a0c-c472d3cf27ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""89c80dc1-9ff3-458c-bebe-d6b2a9e8b0e6"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dark"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CamMovement
        m_CamMovement = asset.FindActionMap("CamMovement", throwIfNotFound: true);
        m_CamMovement_Move = m_CamMovement.FindAction("Move", throwIfNotFound: true);
        m_CamMovement_MousePos = m_CamMovement.FindAction("MousePos", throwIfNotFound: true);
        m_CamMovement_Click = m_CamMovement.FindAction("Click", throwIfNotFound: true);
        m_CamMovement_Zoom = m_CamMovement.FindAction("Zoom", throwIfNotFound: true);
        // Other
        m_Other = asset.FindActionMap("Other", throwIfNotFound: true);
        m_Other_Dark = m_Other.FindAction("Dark", throwIfNotFound: true);
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

    // CamMovement
    private readonly InputActionMap m_CamMovement;
    private List<ICamMovementActions> m_CamMovementActionsCallbackInterfaces = new List<ICamMovementActions>();
    private readonly InputAction m_CamMovement_Move;
    private readonly InputAction m_CamMovement_MousePos;
    private readonly InputAction m_CamMovement_Click;
    private readonly InputAction m_CamMovement_Zoom;
    public struct CamMovementActions
    {
        private @PlayerControls m_Wrapper;
        public CamMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_CamMovement_Move;
        public InputAction @MousePos => m_Wrapper.m_CamMovement_MousePos;
        public InputAction @Click => m_Wrapper.m_CamMovement_Click;
        public InputAction @Zoom => m_Wrapper.m_CamMovement_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_CamMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CamMovementActions set) { return set.Get(); }
        public void AddCallbacks(ICamMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_CamMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CamMovementActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @MousePos.started += instance.OnMousePos;
            @MousePos.performed += instance.OnMousePos;
            @MousePos.canceled += instance.OnMousePos;
            @Click.started += instance.OnClick;
            @Click.performed += instance.OnClick;
            @Click.canceled += instance.OnClick;
            @Zoom.started += instance.OnZoom;
            @Zoom.performed += instance.OnZoom;
            @Zoom.canceled += instance.OnZoom;
        }

        private void UnregisterCallbacks(ICamMovementActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @MousePos.started -= instance.OnMousePos;
            @MousePos.performed -= instance.OnMousePos;
            @MousePos.canceled -= instance.OnMousePos;
            @Click.started -= instance.OnClick;
            @Click.performed -= instance.OnClick;
            @Click.canceled -= instance.OnClick;
            @Zoom.started -= instance.OnZoom;
            @Zoom.performed -= instance.OnZoom;
            @Zoom.canceled -= instance.OnZoom;
        }

        public void RemoveCallbacks(ICamMovementActions instance)
        {
            if (m_Wrapper.m_CamMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICamMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_CamMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CamMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CamMovementActions @CamMovement => new CamMovementActions(this);

    // Other
    private readonly InputActionMap m_Other;
    private List<IOtherActions> m_OtherActionsCallbackInterfaces = new List<IOtherActions>();
    private readonly InputAction m_Other_Dark;
    public struct OtherActions
    {
        private @PlayerControls m_Wrapper;
        public OtherActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Dark => m_Wrapper.m_Other_Dark;
        public InputActionMap Get() { return m_Wrapper.m_Other; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OtherActions set) { return set.Get(); }
        public void AddCallbacks(IOtherActions instance)
        {
            if (instance == null || m_Wrapper.m_OtherActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_OtherActionsCallbackInterfaces.Add(instance);
            @Dark.started += instance.OnDark;
            @Dark.performed += instance.OnDark;
            @Dark.canceled += instance.OnDark;
        }

        private void UnregisterCallbacks(IOtherActions instance)
        {
            @Dark.started -= instance.OnDark;
            @Dark.performed -= instance.OnDark;
            @Dark.canceled -= instance.OnDark;
        }

        public void RemoveCallbacks(IOtherActions instance)
        {
            if (m_Wrapper.m_OtherActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IOtherActions instance)
        {
            foreach (var item in m_Wrapper.m_OtherActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_OtherActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public OtherActions @Other => new OtherActions(this);
    public interface ICamMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMousePos(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
    public interface IOtherActions
    {
        void OnDark(InputAction.CallbackContext context);
    }
}
