using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsDuckConected : MonoBehaviour
{  
    public bool duck;
    public string tag;
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == tag)  duck = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == tag) duck = false;
    }
}
