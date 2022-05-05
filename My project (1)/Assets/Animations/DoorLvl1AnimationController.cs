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
    }

    // Update is called once per frame
    void Update()
    {
        if(start)
        {
            
            lAnim.Play("LeftOpen");
            rAnim.Play("RightOpen");
        }
    }
}
