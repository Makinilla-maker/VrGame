using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel3 : MonoBehaviour
{
    public Animator altar;
    public GameObject doorCollider;
    public GameObject finalNote;
    bool finalNoteBool;
    
    public GameObject roomF;
    bool once;
    public UnityEngine.Video.VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        once = true;
        finalNoteBool = true;
        video.enabled = false;
        finalNote.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (altar.GetCurrentAnimatorStateInfo(0).IsName("Scene") && finalNoteBool)
        {
            finalNote.SetActive(true);
            finalNoteBool = false;         
        }

    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.transform.name == "M9_Knife" && once)
        {
            Debug.Log("WIN");
            altar.Play("Scene");
            //altar.SetBool("activated",true);
            collision.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            video.enabled = true;
            doorCollider.SetActive(false);
            roomF.SetActive(true);
            once = false;
        }
    }
}
