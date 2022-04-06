using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsDuckConected : MonoBehaviour
{  
    public bool duck;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Magazine")    duck = true;
        else duck = false;
    }
}
