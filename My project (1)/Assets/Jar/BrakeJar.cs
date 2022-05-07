using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeJar : MonoBehaviour
{
    private Rigidbody rb;
    public float limitSpeed;
    public GameObject parts;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        parts.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb.velocity.magnitude);
    }
    private void OnCollisionEnter(Collision other)
    {
        if(rb.velocity.magnitude >= limitSpeed)
        {
            Destroy(this.gameObject);
            parts.SetActive(true);
        }
    }
}
