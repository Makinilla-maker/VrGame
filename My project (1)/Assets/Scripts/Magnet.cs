using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public float forceFactor = 200.0f;
    public List<Rigidbody> labirynthBall = new List<Rigidbody>();
    Transform magnetPoint;

    void Start()
    {
        magnetPoint = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        foreach(Rigidbody ball in labirynthBall)
        {
            ball.AddForce((magnetPoint.position - ball.position) * forceFactor * Time.fixedDeltaTime);
        }
    }


    void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Ball"));
            labirynthBall.Add(collider.GetComponent<Rigidbody>());
    }

    void OnTriggerExit(Collider collider)
    {
        if(collider.CompareTag("Ball"));
        labirynthBall.Remove(collider.GetComponent<Rigidbody>());
    }
}
