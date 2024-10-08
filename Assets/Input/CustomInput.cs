//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Input/CustomInput.inputactions
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

public partial class @CustomInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CustomInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CustomInput"",
    ""maps"": [
        {
            ""name"": ""RightHandInteractions"",
            ""id"": ""1d03c32a-acf0-44a3-989e-2f9d9c730cdd"",
            ""actions"": [
                {
                    ""name"": ""Grab"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8915f423-06d8-4328-9417-5b8f3965406b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""caa17487-3980-4932-882b-3477e9e04311"",
                    ""path"": ""<XRController>/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""558245c6-0c14-4a11-a24c-cb4f0f4df96c"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RightHandInteractions
        m_RightHandInteractions = asset.FindActionMap("RightHandInteractions", throwIfNotFound: true);
        m_RightHandInteractions_Grab = m_RightHandInteractions.FindAction("Grab", throwIfNotFound: true);
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

    // RightHandInteractions
    private readonly InputActionMap m_RightHandInteractions;
    private List<IRightHandInteractionsActions> m_RightHandInteractionsActionsCallbackInterfaces = new List<IRightHandInteractionsActions>();
    private readonly InputAction m_RightHandInteractions_Grab;
    public struct RightHandInteractionsActions
    {
        private @CustomInput m_Wrapper;
        public RightHandInteractionsActions(@CustomInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grab => m_Wrapper.m_RightHandInteractions_Grab;
        public InputActionMap Get() { return m_Wrapper.m_RightHandInteractions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightHandInteractionsActions set) { return set.Get(); }
        public void AddCallbacks(IRightHandInteractionsActions instance)
        {
            if (instance == null || m_Wrapper.m_RightHandInteractionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RightHandInteractionsActionsCallbackInterfaces.Add(instance);
            @Grab.started += instance.OnGrab;
            @Grab.performed += instance.OnGrab;
            @Grab.canceled += instance.OnGrab;
        }

        private void UnregisterCallbacks(IRightHandInteractionsActions instance)
        {
            @Grab.started -= instance.OnGrab;
            @Grab.performed -= instance.OnGrab;
            @Grab.canceled -= instance.OnGrab;
        }

        public void RemoveCallbacks(IRightHandInteractionsActions instance)
        {
            if (m_Wrapper.m_RightHandInteractionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRightHandInteractionsActions instance)
        {
            foreach (var item in m_Wrapper.m_RightHandInteractionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RightHandInteractionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RightHandInteractionsActions @RightHandInteractions => new RightHandInteractionsActions(this);
    public interface IRightHandInteractionsActions
    {
        void OnGrab(InputAction.CallbackContext context);
    }
}
