//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Player2Controls.inputactions
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

public partial class @Player2Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player2Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player2Controls"",
    ""maps"": [
        {
            ""name"": ""Controls"",
            ""id"": ""ae95bd47-c72b-435a-a1ed-d5e5b4059d7b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""42f3c677-7d25-4ea2-8af7-38108db2ad3b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Drift"",
                    ""type"": ""Button"",
                    ""id"": ""d0f87e68-c253-4898-afef-03e40930b2e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""65e2ca40-5e26-4b8a-b823-5028a2e32eb8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""644c2804-8d8d-465e-b569-d08ac3506e4f"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""261b0397-3f74-4344-8cf8-03336d4e3093"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b7462d16-3cd0-46d4-b2ca-b5832a0a8e52"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""99adf11c-4f8d-468a-ae60-c6a769d1be60"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1a471df2-d9a0-4251-b675-cbb3a886c13e"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Controls
        m_Controls = asset.FindActionMap("Controls", throwIfNotFound: true);
        m_Controls_Movement = m_Controls.FindAction("Movement", throwIfNotFound: true);
        m_Controls_Drift = m_Controls.FindAction("Drift", throwIfNotFound: true);
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

    // Controls
    private readonly InputActionMap m_Controls;
    private List<IControlsActions> m_ControlsActionsCallbackInterfaces = new List<IControlsActions>();
    private readonly InputAction m_Controls_Movement;
    private readonly InputAction m_Controls_Drift;
    public struct ControlsActions
    {
        private @Player2Controls m_Wrapper;
        public ControlsActions(@Player2Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Controls_Movement;
        public InputAction @Drift => m_Wrapper.m_Controls_Drift;
        public InputActionMap Get() { return m_Wrapper.m_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlsActions set) { return set.Get(); }
        public void AddCallbacks(IControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_ControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ControlsActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Drift.started += instance.OnDrift;
            @Drift.performed += instance.OnDrift;
            @Drift.canceled += instance.OnDrift;
        }

        private void UnregisterCallbacks(IControlsActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Drift.started -= instance.OnDrift;
            @Drift.performed -= instance.OnDrift;
            @Drift.canceled -= instance.OnDrift;
        }

        public void RemoveCallbacks(IControlsActions instance)
        {
            if (m_Wrapper.m_ControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_ControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ControlsActions @Controls => new ControlsActions(this);
    public interface IControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnDrift(InputAction.CallbackContext context);
    }
}
