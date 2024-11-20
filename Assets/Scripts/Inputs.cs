// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Inputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Jogador"",
            ""id"": ""ed6b6530-0b0d-4658-b0fd-e06f1c5d7fa7"",
            ""actions"": [
                {
                    ""name"": ""Mover"",
                    ""type"": ""Value"",
                    ""id"": ""ffc5fd67-783d-44c8-a173-50671c2e00c9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interagir"",
                    ""type"": ""Button"",
                    ""id"": ""0d5795cb-15d1-48c0-a6fe-b91db4965bb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Correr"",
                    ""type"": ""Button"",
                    ""id"": ""01f0ec14-7532-4ca8-8b00-bfa1f48e6f8f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectAxe"",
                    ""type"": ""Button"",
                    ""id"": ""6e4b3549-17f0-408d-97c2-f8be5054e8a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectShovel"",
                    ""type"": ""Button"",
                    ""id"": ""57143668-0a10-473a-9836-2eb23f0abe2b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectWaterCan"",
                    ""type"": ""Button"",
                    ""id"": ""2832e5a0-478c-45ff-b1f3-0b2947e2ccaa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectToolMinus"",
                    ""type"": ""Button"",
                    ""id"": ""16decf10-ee40-4915-ae67-f5e3ccadc0d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectToolPlus"",
                    ""type"": ""Button"",
                    ""id"": ""09795d88-27c3-45f5-819d-1334ab453a13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""76d1981f-9bd9-4fb8-bd60-3a3888ea8117"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""168d4fb1-0095-4118-98a3-c9517bca2926"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleSound"",
                    ""type"": ""Button"",
                    ""id"": ""ced3ad70-2caf-4c58-8342-23a7dee1ed05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""32acd7ec-f46e-4bd7-b2c1-9e8ebe2aa795"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c42fc4ce-de14-4a16-ba56-a8a32e32ad8b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""1dbbe844-61a2-45f4-8295-462029800204"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9d938a3b-a7f3-4526-bdd8-46f964b7ea87"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a7f39398-f118-4f1f-904a-af161a0551aa"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b74ccb68-bc6d-4582-b634-470e55876136"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5d3626b3-6cdc-406a-80d7-f26bb8c42a9d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""4e17cff9-a609-429b-9671-427adc33433b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a00fc864-ce3d-49f9-ad74-0fd2df50724f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""36454ec1-8f1a-46f9-bce3-50bb1fa3b4a1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""339c0491-137f-48c5-8e71-c177aa66fe0f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3357721f-ce47-491a-a7ab-968dae51c2b5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ef7c11f5-e143-4e32-ac8f-7704f76fd8ba"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06aa55bf-d4b8-4518-bfbd-4163431b638c"",
                    ""path"": ""<HID::Performance Designed Products Faceoff Premiere Wired Pro Controller for Nintendo Switch>/hat"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be095658-07ac-4124-886d-723866f56df2"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interagir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71aa695d-086a-4b13-a4e5-8c13a55aadd4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interagir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f9dcccf-eb76-46a8-b0f6-2c93864d3ad7"",
                    ""path"": ""<HID::Performance Designed Products Faceoff Premiere Wired Pro Controller for Nintendo Switch>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interagir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79508acd-250c-4a0c-b194-3f18066b9e84"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01e1bf1e-331b-46f2-bf32-cde19566faf2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e0a7f36-c6f1-4799-ae89-984b6f3429a8"",
                    ""path"": ""<HID::Performance Designed Products Faceoff Premiere Wired Pro Controller for Nintendo Switch>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ad30a45-bde0-4dee-94a2-821f80f05b7a"",
                    ""path"": ""<HID::Performance Designed Products Faceoff Premiere Wired Pro Controller for Nintendo Switch>/button11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58ffa2c0-a8e7-4d14-91b5-a2a567a891f4"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectAxe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5eacf441-cda8-482a-8e9f-5e17aeb4ce19"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectShovel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e72f248d-3d16-47f9-b7c7-749df680c4df"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWaterCan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f75f9944-1f32-4393-a426-b4afca1954b6"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectToolMinus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7175255-3d5f-49e7-9875-a8c8f0596470"",
                    ""path"": ""<HID::Performance Designed Products Faceoff Premiere Wired Pro Controller for Nintendo Switch>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectToolMinus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b513c294-3b2c-42bd-a929-852a9f783b40"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectToolPlus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1125de89-00d7-4c41-bd29-1ead11563a24"",
                    ""path"": ""<HID::Performance Designed Products Faceoff Premiere Wired Pro Controller for Nintendo Switch>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectToolPlus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78de0471-6a53-4e94-bccb-c5419dfd5da7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a32ca9c1-7516-46eb-97b8-1d16dee78b4e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88b7db5c-d7c8-487a-a958-f2cdbbccf8db"",
                    ""path"": ""<HID::Performance Designed Products Faceoff Premiere Wired Pro Controller for Nintendo Switch>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cc19c1f-770d-4cf6-8ee7-4a5252f8bd7c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21799379-136b-4ee9-ab06-cb200bd02be2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ebfa721-ee81-4c1c-9947-e0fbbca45502"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fdf2e9c-3dff-45a5-be61-b9f8e462a812"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleSound"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f46ed76-efb4-4263-97e8-e31ac7a6f664"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleSound"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7467116e-258d-4e0b-92dc-8e301839f4ad"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2ebc86e-0467-4fb0-8da4-753f53bb06a6"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Jogador
        m_Jogador = asset.FindActionMap("Jogador", throwIfNotFound: true);
        m_Jogador_Mover = m_Jogador.FindAction("Mover", throwIfNotFound: true);
        m_Jogador_Interagir = m_Jogador.FindAction("Interagir", throwIfNotFound: true);
        m_Jogador_Correr = m_Jogador.FindAction("Correr", throwIfNotFound: true);
        m_Jogador_SelectAxe = m_Jogador.FindAction("SelectAxe", throwIfNotFound: true);
        m_Jogador_SelectShovel = m_Jogador.FindAction("SelectShovel", throwIfNotFound: true);
        m_Jogador_SelectWaterCan = m_Jogador.FindAction("SelectWaterCan", throwIfNotFound: true);
        m_Jogador_SelectToolMinus = m_Jogador.FindAction("SelectToolMinus", throwIfNotFound: true);
        m_Jogador_SelectToolPlus = m_Jogador.FindAction("SelectToolPlus", throwIfNotFound: true);
        m_Jogador_Roll = m_Jogador.FindAction("Roll", throwIfNotFound: true);
        m_Jogador_Action = m_Jogador.FindAction("Action", throwIfNotFound: true);
        m_Jogador_ToggleSound = m_Jogador.FindAction("ToggleSound", throwIfNotFound: true);
        m_Jogador_PauseGame = m_Jogador.FindAction("PauseGame", throwIfNotFound: true);
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

    // Jogador
    private readonly InputActionMap m_Jogador;
    private IJogadorActions m_JogadorActionsCallbackInterface;
    private readonly InputAction m_Jogador_Mover;
    private readonly InputAction m_Jogador_Interagir;
    private readonly InputAction m_Jogador_Correr;
    private readonly InputAction m_Jogador_SelectAxe;
    private readonly InputAction m_Jogador_SelectShovel;
    private readonly InputAction m_Jogador_SelectWaterCan;
    private readonly InputAction m_Jogador_SelectToolMinus;
    private readonly InputAction m_Jogador_SelectToolPlus;
    private readonly InputAction m_Jogador_Roll;
    private readonly InputAction m_Jogador_Action;
    private readonly InputAction m_Jogador_ToggleSound;
    private readonly InputAction m_Jogador_PauseGame;
    public struct JogadorActions
    {
        private @Inputs m_Wrapper;
        public JogadorActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mover => m_Wrapper.m_Jogador_Mover;
        public InputAction @Interagir => m_Wrapper.m_Jogador_Interagir;
        public InputAction @Correr => m_Wrapper.m_Jogador_Correr;
        public InputAction @SelectAxe => m_Wrapper.m_Jogador_SelectAxe;
        public InputAction @SelectShovel => m_Wrapper.m_Jogador_SelectShovel;
        public InputAction @SelectWaterCan => m_Wrapper.m_Jogador_SelectWaterCan;
        public InputAction @SelectToolMinus => m_Wrapper.m_Jogador_SelectToolMinus;
        public InputAction @SelectToolPlus => m_Wrapper.m_Jogador_SelectToolPlus;
        public InputAction @Roll => m_Wrapper.m_Jogador_Roll;
        public InputAction @Action => m_Wrapper.m_Jogador_Action;
        public InputAction @ToggleSound => m_Wrapper.m_Jogador_ToggleSound;
        public InputAction @PauseGame => m_Wrapper.m_Jogador_PauseGame;
        public InputActionMap Get() { return m_Wrapper.m_Jogador; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JogadorActions set) { return set.Get(); }
        public void SetCallbacks(IJogadorActions instance)
        {
            if (m_Wrapper.m_JogadorActionsCallbackInterface != null)
            {
                @Mover.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMover;
                @Mover.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMover;
                @Mover.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMover;
                @Interagir.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnInteragir;
                @Interagir.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnInteragir;
                @Interagir.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnInteragir;
                @Correr.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnCorrer;
                @Correr.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnCorrer;
                @Correr.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnCorrer;
                @SelectAxe.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectAxe;
                @SelectAxe.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectAxe;
                @SelectAxe.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectAxe;
                @SelectShovel.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectShovel;
                @SelectShovel.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectShovel;
                @SelectShovel.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectShovel;
                @SelectWaterCan.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectWaterCan;
                @SelectWaterCan.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectWaterCan;
                @SelectWaterCan.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectWaterCan;
                @SelectToolMinus.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectToolMinus;
                @SelectToolMinus.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectToolMinus;
                @SelectToolMinus.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectToolMinus;
                @SelectToolPlus.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectToolPlus;
                @SelectToolPlus.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectToolPlus;
                @SelectToolPlus.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnSelectToolPlus;
                @Roll.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnRoll;
                @Action.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnAction;
                @ToggleSound.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnToggleSound;
                @ToggleSound.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnToggleSound;
                @ToggleSound.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnToggleSound;
                @PauseGame.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPauseGame;
                @PauseGame.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPauseGame;
                @PauseGame.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPauseGame;
            }
            m_Wrapper.m_JogadorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mover.started += instance.OnMover;
                @Mover.performed += instance.OnMover;
                @Mover.canceled += instance.OnMover;
                @Interagir.started += instance.OnInteragir;
                @Interagir.performed += instance.OnInteragir;
                @Interagir.canceled += instance.OnInteragir;
                @Correr.started += instance.OnCorrer;
                @Correr.performed += instance.OnCorrer;
                @Correr.canceled += instance.OnCorrer;
                @SelectAxe.started += instance.OnSelectAxe;
                @SelectAxe.performed += instance.OnSelectAxe;
                @SelectAxe.canceled += instance.OnSelectAxe;
                @SelectShovel.started += instance.OnSelectShovel;
                @SelectShovel.performed += instance.OnSelectShovel;
                @SelectShovel.canceled += instance.OnSelectShovel;
                @SelectWaterCan.started += instance.OnSelectWaterCan;
                @SelectWaterCan.performed += instance.OnSelectWaterCan;
                @SelectWaterCan.canceled += instance.OnSelectWaterCan;
                @SelectToolMinus.started += instance.OnSelectToolMinus;
                @SelectToolMinus.performed += instance.OnSelectToolMinus;
                @SelectToolMinus.canceled += instance.OnSelectToolMinus;
                @SelectToolPlus.started += instance.OnSelectToolPlus;
                @SelectToolPlus.performed += instance.OnSelectToolPlus;
                @SelectToolPlus.canceled += instance.OnSelectToolPlus;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @ToggleSound.started += instance.OnToggleSound;
                @ToggleSound.performed += instance.OnToggleSound;
                @ToggleSound.canceled += instance.OnToggleSound;
                @PauseGame.started += instance.OnPauseGame;
                @PauseGame.performed += instance.OnPauseGame;
                @PauseGame.canceled += instance.OnPauseGame;
            }
        }
    }
    public JogadorActions @Jogador => new JogadorActions(this);
    public interface IJogadorActions
    {
        void OnMover(InputAction.CallbackContext context);
        void OnInteragir(InputAction.CallbackContext context);
        void OnCorrer(InputAction.CallbackContext context);
        void OnSelectAxe(InputAction.CallbackContext context);
        void OnSelectShovel(InputAction.CallbackContext context);
        void OnSelectWaterCan(InputAction.CallbackContext context);
        void OnSelectToolMinus(InputAction.CallbackContext context);
        void OnSelectToolPlus(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnToggleSound(InputAction.CallbackContext context);
        void OnPauseGame(InputAction.CallbackContext context);
    }
}
