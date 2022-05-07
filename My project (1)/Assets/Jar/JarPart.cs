using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JarPart : MonoBehaviour
{
    private Rigidbody rb;
    public Material newMat;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        GetComponent<Renderer>().material = newMat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
