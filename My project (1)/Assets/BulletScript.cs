using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody rb;
    public float destroyTime;
    private float destroyTime1;
    private bool startCount;
    private Vector3 colPos;
    private Quaternion colQuat;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        destroyTime1 = destroyTime;
        startCount = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(startCount)
        {
            transform.position = colPos;
            transform.rotation = colQuat;
            if(destroyTime > 0)
            {
                destroyTime -= Time.deltaTime;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Bullet")
        {
            colPos = rb.transform.position;
            colQuat = rb.transform.rotation;
            startCount = true;
        }              
    }
}
