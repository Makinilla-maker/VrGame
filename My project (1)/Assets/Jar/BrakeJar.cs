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
        //parts.SetActive(false);
        foreach(Transform child in parts.transform)
        {
            child.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb.velocity.magnitude);
        parts.transform.position = transform.position;
    }
    private void OnCollisionEnter(Collision other)
    {
        if(rb.velocity.magnitude >= limitSpeed)
        {
            foreach(Transform child in parts.transform)
            {
                child.GetComponent<MeshRenderer>().enabled = true;
            }
            Destroy(this.gameObject);
        }
    }
}
