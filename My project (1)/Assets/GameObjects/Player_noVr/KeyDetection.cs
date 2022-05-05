using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDetection : MonoBehaviour
{
    private LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void R()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 10f))
        {
            if(hit.transform.tag == "KeypadButton")
            {
                lr.SetPosition(0,transform.position);
                lr.SetPosition(1,hit.point);
                Debug.Log(hit.transform.gameObject.ToString());
            }
        }
    }
}
