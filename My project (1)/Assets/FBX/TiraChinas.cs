using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiraChinas : MonoBehaviour
{
    public GameObject anchor1;
    public GameObject anchor2;
    SpringJoint joint;
    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<SpringJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
