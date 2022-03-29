using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnimation : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    public void Reload()
    {
        anim.SetBool("reload", true);
        anim.SetBool("reloaded", false);
    }
    // Update is called once per frame
    void Update()
    {
        //if()
    }
}
