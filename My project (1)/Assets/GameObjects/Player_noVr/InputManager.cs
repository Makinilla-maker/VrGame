using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Movement movemnet;
    [SerializeField] MouseLook mouseLook;
    Player_NoVr controls;
    Player_NoVr.NewactionmapActions groundMovement;
    Vector2 horizontalInput;
    Vector2 mouseInput;
    // Start is called before the first frame update
    private void Awake()
    {
        controls = new Player_NoVr();
        groundMovement = controls.Newactionmap;
        groundMovement.ground.performed += ctx =>horizontalInput = ctx.ReadValue<Vector2>();
        groundMovement.MouseX.performed+=ctx =>mouseInput.x = ctx.ReadValue<float>();
        groundMovement.MouseY.performed+=ctx =>mouseInput.y = ctx.ReadValue<float>();
    }
    void Start()
    {
        
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDestroy()
    {
        controls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        movemnet.ReceiveInput(horizontalInput);
        mouseLook.ReceiveInput(mouseInput);
    }
}
