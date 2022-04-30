using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float sens = 8f;
    [SerializeField] Transform playerBody;

    float mouseX;
    float mouseY;

    float xRot;

    public void ReceiveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x*sens;
        mouseY = mouseInput.y*sens;
    }

    // Update is called once per frame
    void Update()
    {
        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot,-90f,90f);
        transform.localRotation = Quaternion.Euler(xRot,0f,0f);
        Cursor.lockState = CursorLockMode.Locked;
        playerBody.Rotate(Vector3.up*mouseX);
    }
}
