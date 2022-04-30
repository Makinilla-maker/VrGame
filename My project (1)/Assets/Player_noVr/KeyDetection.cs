using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        R();
    }
    public void R()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 10f))
        {
            if(hit.transform.gameObject.layer.ToString() == "Keypad")
            {
                Debug.Log(hit.transform.gameObject.ToString());
            }
        }
    }
}
