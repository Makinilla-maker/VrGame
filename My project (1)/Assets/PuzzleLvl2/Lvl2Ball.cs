using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2Ball : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 startPos;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "BallRestart")
        {
            transform.position = startPos;
            rb.velocity = Vector3.zero;
        }
    }
}
