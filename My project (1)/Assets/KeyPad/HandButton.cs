using System;
using UnityEngine;
using UnityEngine.Events;

public class HandButton : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;

    private AudioSource audio;
    public Key generalPassword;
    private bool isPressed;
    public Color startColor;
    public  Color selectedColor;
    private Vector3 startPos;
    public UnityEvent onPressed, onReleased;
    public GameObject selectedButton;
    [SerializeField] private ConfigurableJoint joint;

    void Start()
    {
        startColor = GetComponent<Renderer>().material.color;
        joint = GetComponent<ConfigurableJoint>();
        audio = GetComponent<AudioSource>();
        startPos = transform.localPosition;
        generalPassword.i = -1;
        isPressed = true;
    }
    void OnTriggerEnter(Collider other)
    {
        if(isPressed)
        {
            gameObject.GetComponent<Renderer>().material.color = selectedColor;
            audio.Play();
            generalPassword.i++;
            if(generalPassword.i <= 3)     generalPassword.pas[generalPassword.i] = this.gameObject.name[0];
            isPressed = false;
        }
        generalPassword.s = new string(generalPassword.pas);
        Debug.Log("Pressed");
    }
    void OnTriggerExit(Collider other)
    {
        isPressed = true;
        Debug.Log("Released");
    }
}
