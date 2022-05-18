//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/GameObjects/Player_noVr/Player_NoVr.inputactions
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

public partial class @Player_NoVr : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_NoVr()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_NoVr"",
    ""maps"": [
        {
            ""name"": ""New action map"",
            ""id"": ""5f47f51f-0915-45b5-9bea-9593640458fe"",
            ""actions"": [
                {
                    ""name"": ""ground"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4010b513-4712-4e43-91c5-2e013ef07b78"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""150f1afa-c802-48cf-8de8-18e3e6799ff6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c97b8687-4927-403f-8212-edd7262118ae"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Raycast"",
                    ""type"": ""Button"",
                    ""id"": ""f9274aac-0e2f-42ab-9f21-40715bf24e84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1c427081-bc87-4a4d-9199-8044524a3387"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ground"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7d71a19c-da51-4bae-972d-1e3ac1618d80"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ground"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c368b1d1-10c5-4368-9360-8165e614a1d9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ground"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b63a8f84-fece-4886-b1df-17ec906f57f1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ground"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4471f23b-1708-4ed9-8f55-684391a2ec50"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ground"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d57e4e27-77d1-49cb-a1d1-5b782cc9cf11"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b87acf1a-361a-41db-a911-3d85d5538993"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd301b1f-4ab6-4552-accc-0ffceda17720"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Raycast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // New action map
        m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
        m_Newactionmap_ground = m_Newactionmap.FindAction("ground", throwIfNotFound: true);
        m_Newactionmap_MouseX = m_Newactionmap.FindAction("MouseX", throwIfNotFound: true);
        m_Newactionmap_MouseY = m_Newactionmap.FindAction("MouseY", throwIfNotFound: true);
        m_Newactionmap_Raycast = m_Newactionmap.FindAction("Raycast", throwIfNotFound: true);
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

    // New action map
    private readonly InputActionMap m_Newactionmap;
    private INewactionmapActions m_NewactionmapActionsCallbackInterface;
    private readonly InputAction m_Newactionmap_ground;
    private readonly InputAction m_Newactionmap_MouseX;
    private readonly InputAction m_Newactionmap_MouseY;
    private readonly InputAction m_Newactionmap_Raycast;
    public struct NewactionmapActions
    {
        private @Player_NoVr m_Wrapper;
        public NewactionmapActions(@Player_NoVr wrapper) { m_Wrapper = wrapper; }
        public InputAction @ground => m_Wrapper.m_Newactionmap_ground;
        public InputAction @MouseX => m_Wrapper.m_Newactionmap_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Newactionmap_MouseY;
        public InputAction @Raycast => m_Wrapper.m_Newactionmap_Raycast;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
        public void SetCallbacks(INewactionmapActions instance)
        {
            if (m_Wrapper.m_NewactionmapActionsCallbackInterface != null)
            {
                @ground.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnGround;
                @ground.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnGround;
                @ground.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnGround;
                @MouseX.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnMouseY;
                @Raycast.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnRaycast;
                @Raycast.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnRaycast;
                @Raycast.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnRaycast;
            }
            m_Wrapper.m_NewactionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ground.started += instance.OnGround;
                @ground.performed += instance.OnGround;
                @ground.canceled += instance.OnGround;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @Raycast.started += instance.OnRaycast;
                @Raycast.performed += instance.OnRaycast;
                @Raycast.canceled += instance.OnRaycast;
            }
        }
    }
    public NewactionmapActions @Newactionmap => new NewactionmapActions(this);
    public interface INewactionmapActions
    {
        void OnGround(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnRaycast(InputAction.CallbackContext context);
    }
}
