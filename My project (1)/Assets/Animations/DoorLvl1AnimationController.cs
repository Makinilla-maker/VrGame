using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLvl1AnimationController : MonoBehaviour
{
    public Animator lAnim;
    public Animator rAnim;
    public bool start = false;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        start = false;
        audio = GetComponent<AudioSource>();
        Debug.Log(this.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        if(start)
        {
            if(this.gameObject.name == "DoorD_V2 (2)")
            {
                lAnim.Play("TheatreLeftDoorOpen");
                rAnim.Play("TheatreRightDoorMove");
            }
            else
            {
                lAnim.Play("LeftOpen");
                rAnim.Play("RightOpen");
            }
            
        }
    }
}
