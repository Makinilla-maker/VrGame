using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel3 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "M9_Knife" && collision.transform.GetComponent<CapsuleCollider>().enabled)
        {
            Debug.Log("WIN");
            collision.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
