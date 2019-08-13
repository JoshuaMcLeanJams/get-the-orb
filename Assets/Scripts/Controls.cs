// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Controls : IInputActionCollection
{
    private InputActionAsset asset;
    public Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""b0cd5a6e-e491-40b7-8986-14920ec203fe"",
            ""actions"": [
                {
                    ""name"": ""Forward"",
                    ""type"": ""Value"",
                    ""id"": ""68a28017-499f-47c8-b21c-53ce3389ef11"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Button"",
                    ""id"": ""5eb367f1-c5ff-4293-9b9f-b2d5c818faa1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""82c98b4b-2e32-4b52-87a0-fa7378510682"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button A"",
                    ""type"": ""Button"",
                    ""id"": ""9ab549b6-7bbf-4431-a27c-6753c7514a0d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Button B"",
                    ""type"": ""Button"",
                    ""id"": ""cf6897a9-d98e-488e-b9c4-c9f9932f8f69"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""c6bd390e-bc79-4116-856a-b47ebcbf7ff3"",
                    ""path"": ""1DAxis(whichSideWins=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fab18616-f962-407e-a009-cd9a064fa3e3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5629766c-b2e5-4604-8976-2578db3f000b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""f54a2068-5878-475a-9f4c-f6d001596aff"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a2a14764-c2cd-4aa1-9bff-c90564c883d6"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c9eae7d0-5a7f-4f87-a0d0-f36cade5f856"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""edbaf57d-27c8-4c09-8a8e-611a345d196e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""776d7f42-a968-4e01-8d63-cf1f56757dae"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""99d46ca6-b5a1-4712-ad4c-99e20caff4d4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""d43dee83-cf05-4b80-b1c7-f62534deee39"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b3a79555-2f20-4aec-a3b7-5b851578550e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d791ce08-e01f-4724-bcc6-0d0284e0ccbf"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""eeb8cbbe-74e0-46da-a705-dabb90d26560"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32f623f2-7414-4371-8557-6c3c73c589b3"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Button B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.GetActionMap("Movement");
        m_Movement_Forward = m_Movement.GetAction("Forward");
        m_Movement_Turn = m_Movement.GetAction("Turn");
        m_Movement_Dash = m_Movement.GetAction("Dash");
        m_Movement_ButtonA = m_Movement.GetAction("Button A");
        m_Movement_ButtonB = m_Movement.GetAction("Button B");
    }

    ~Controls()
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Forward;
    private readonly InputAction m_Movement_Turn;
    private readonly InputAction m_Movement_Dash;
    private readonly InputAction m_Movement_ButtonA;
    private readonly InputAction m_Movement_ButtonB;
    public struct MovementActions
    {
        private Controls m_Wrapper;
        public MovementActions(Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forward => m_Wrapper.m_Movement_Forward;
        public InputAction @Turn => m_Wrapper.m_Movement_Turn;
        public InputAction @Dash => m_Wrapper.m_Movement_Dash;
        public InputAction @ButtonA => m_Wrapper.m_Movement_ButtonA;
        public InputAction @ButtonB => m_Wrapper.m_Movement_ButtonB;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                Forward.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnForward;
                Forward.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnForward;
                Forward.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnForward;
                Turn.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnTurn;
                Turn.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnTurn;
                Turn.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnTurn;
                Dash.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnDash;
                Dash.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnDash;
                Dash.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnDash;
                ButtonA.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnButtonA;
                ButtonA.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnButtonA;
                ButtonA.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnButtonA;
                ButtonB.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnButtonB;
                ButtonB.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnButtonB;
                ButtonB.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnButtonB;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                Forward.started += instance.OnForward;
                Forward.performed += instance.OnForward;
                Forward.canceled += instance.OnForward;
                Turn.started += instance.OnTurn;
                Turn.performed += instance.OnTurn;
                Turn.canceled += instance.OnTurn;
                Dash.started += instance.OnDash;
                Dash.performed += instance.OnDash;
                Dash.canceled += instance.OnDash;
                ButtonA.started += instance.OnButtonA;
                ButtonA.performed += instance.OnButtonA;
                ButtonA.canceled += instance.OnButtonA;
                ButtonB.started += instance.OnButtonB;
                ButtonB.performed += instance.OnButtonB;
                ButtonB.canceled += instance.OnButtonB;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnForward(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnButtonA(InputAction.CallbackContext context);
        void OnButtonB(InputAction.CallbackContext context);
    }
}
