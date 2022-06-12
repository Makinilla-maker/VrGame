using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPz2 : MonoBehaviour
{
    public DoorLvl1AnimationController anim;
    public Rigidbody rb;
    public GameObject pz3;
    // Start is called before the first frame update
    void Start()
    {
        anim.start = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "End_Pz_2")
        {
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
