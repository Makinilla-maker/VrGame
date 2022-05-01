using System;
using UnityEngine;
using UnityEngine.Events;

public class HandButton : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;

    public Key generalPassword;
    private bool isPressed;
    private Color startColor;
    private Vector3 startPos;
    public UnityEvent onPressed, onReleased;
    public GameObject selectedButton;
    [SerializeField] private ConfigurableJoint joint;

    void Start()
    {
        startColor = GetComponent<Renderer>().material.color;
        joint = GetComponent<ConfigurableJoint>();
        startPos = transform.localPosition;
    }

    void Update()
    {
        // if(!isPressed && GetValue() + threshold >= 1)
        //     Pressed();

        // if(isPressed && GetValue() - threshold <= 0)
        //     Released();
    }
    void OnTriggerEnter(Collider other)
    {
        isPressed = true;
        if(generalPassword.pas[generalPassword.i] == '0' && isPressed)
        {
            generalPassword.pas[generalPassword.i] = this.gameObject.name[0];
        }
        generalPassword.s = new string(generalPassword.pas);
        Debug.Log("Pressed");
    }
    void OnTriggerExit(Collider other)
    {
        generalPassword.i++;
        isPressed = false;
        Debug.Log("Released");
    }
}
