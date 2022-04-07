using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsDuckConected : MonoBehaviour
{  
    public bool duck;
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "GunSphere")  duck = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "GunSphere") duck = false;
    }
}
