using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnop : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Grav()
    {
        rb.useGravity = true;
    }
}
