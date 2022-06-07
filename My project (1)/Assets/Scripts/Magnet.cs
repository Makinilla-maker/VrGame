using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public float forceFactor = 200.0f;
    public Rigidbody labirynthBall;
    Transform magnetPoint;

    void Start()
    {
        magnetPoint = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        
    }


    void OnTriggerStay(Collider collider)
    {
        if(collider.CompareTag("Ball"))
        {
            labirynthBall.AddForce((magnetPoint.position - labirynthBall.position) * forceFactor);
        }
    }

}
