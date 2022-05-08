using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeJar : MonoBehaviour
{
    private Rigidbody rb;
    public float limitSpeed;
    public GameObject parts;
    public GameObject main;
    public GameObject tap;
    public GameObject whatsInside;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        main.SetActive(true);
        // foreach(Transform child in parts.transform)
        // {
        //     if(child.gameObject.name != "iman")
        //     {
        //         child.GetComponent<MeshRenderer>().enabled = false;
        //     }
        //     child.GetComponent<MeshCollider>().enabled = false;
        // }
        parts.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.relativeVelocity.magnitude >= limitSpeed && other.gameObject.layer != LayerMask.NameToLayer("Default"))
        {
            Destroy(tap.gameObject);
            main.SetActive(false);
            parts.SetActive(true);
            if (whatsInside.GetComponent<Rigidbody>() != null)
            {
                Rigidbody r = whatsInside.AddComponent<Rigidbody>();
                r.mass = 1;
                r.collisionDetectionMode = CollisionDetectionMode.Continuous;
            }
               
            if(whatsInside.GetComponent<XROffset>()!= null)
            {
                XROffset x = whatsInside.AddComponent<XROffset>();
                x.movementType = UnityEngine.XR.Interaction.Toolkit.XRBaseInteractable.MovementType.VelocityTracking;
            }                
        }
    }
}
