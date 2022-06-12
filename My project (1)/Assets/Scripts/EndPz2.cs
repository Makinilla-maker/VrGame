using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPz2 : MonoBehaviour
{
    public DoorLvl1AnimationController anim;
    public Rigidbody rb;
    public GameObject pz3;
    public Light l1;
    public Light l2;
    public float lI;
    // Start is called before the first frame update
    void Start()
    {
        anim.start = false;
        lI = l1.intensity;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "End_Pz_2")
        {
            l1.intensity = lI;
            l2.intensity = lI;
            pz3.SetActive(true);
            StartCoroutine(WaitForMe());
        }
        if (other.name == "Exit")
        {
            gameObject.AddComponent<XROffset>();
        }
    }

    IEnumerator WaitForMe()
    {
        yield return new WaitForSeconds(.5f);
        anim.start = true;
    }
}
