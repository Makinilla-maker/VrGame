using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel3 : MonoBehaviour
{
    public Animator altar;
    public GameObject doorCollider;
    public GameObject finalNote;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (altar.GetCurrentAnimatorStateInfo(0).IsName("Scene"))
        {
            Instantiate(finalNote);            
        }

    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.name == "M9_Knife")
        {
            Debug.Log("WIN");
            altar.Play("Scene");
            //altar.SetBool("activated",true);
            collision.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            Destroy(doorCollider);
        }
    }
}
