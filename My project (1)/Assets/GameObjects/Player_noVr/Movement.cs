using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 11f;
    [SerializeField] float gravity = -9.8f;
    Vector3 vV = Vector3.zero;
    Vector2 horizontalInput;
    public Camera playercamera;
    public void ReceiveInput(Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput;
    }
    private void Update()
    {
        Vector3 hV = (playercamera.transform.right * horizontalInput.x + playercamera.transform.forward*horizontalInput.y)*speed;
        controller.Move(hV*Time.deltaTime);
        vV.y += gravity*Time.deltaTime;
        controller.Move(vV*Time.deltaTime);
    }
}
