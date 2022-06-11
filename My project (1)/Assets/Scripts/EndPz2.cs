using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPz2 : MonoBehaviour
{
    public DoorLvl1AnimationController anim;
    public Rigidbody rb;
    public AudioSource audioS;
    // Start is called before the first frame update
    void Start()
    {
        anim.start = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity != Vector3.zero)
        {
            audioS.enabled = true;
            audioS.Play();
        }
        else if(rb.velocity == Vector3.zero)
        {
            audioS.enabled = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "End_Pz_2")
        {
            anim.start = true;
        }
        if (other.name == "Exit")
        {
            gameObject.AddComponent<XROffset>();
        }
    }
}
