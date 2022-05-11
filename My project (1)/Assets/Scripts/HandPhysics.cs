using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPhysics : MonoBehaviour
{
    public Transform target;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = (target.position-transform.position)/Time.fixedDeltaTime;

        Quaternion rotDiff = target.rotation * Quaternion.Inverse(transform.rotation);
        rotDiff.ToAngleAxis(out float angleInDegree, out Vector3 rotationAxis);
        Vector3 rotDiffInDegree = angleInDegree * rotationAxis;

        rb.angularVelocity = (rotDiffInDegree * Mathf.Deg2Rad / Time.fixedDeltaTime);
    }
}
