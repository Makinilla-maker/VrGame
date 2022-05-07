using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeJar : MonoBehaviour
{
    private Rigidbody rb;
    public float limitSpeed;
    public GameObject parts;
    public GameObject main;
    public GameObject tap;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        main.SetActive(true);
        // foreach(Transform child in parts.transform)
        // {
        //     if(child.gameObject.name != "iman")
        //     {
        //         child.GetComponent<MeshRenderer>().enabled = false;
        //     }
        //     child.GetComponent<MeshCollider>().enabled = false;
        // }
        parts.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.relativeVelocity.magnitude >= limitSpeed && other.gameObject.layer == 6)
        {
            Destroy(tap.gameObject);
            main.SetActive(false);
            parts.SetActive(true);
        }
    }
}
