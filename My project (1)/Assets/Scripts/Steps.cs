using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steps : MonoBehaviour
{
    public AudioSource steps;
    public Transform XRrig;
    public Vector3 comprovar;
    public Vector3 comprovar1;
    
    void Start()
    {
        comprovar = XRrig.position;
    }
    public void Update()
    {
        comprovar1 = XRrig.position;
    }

    public void FootSteps()
    {
       StartCoroutine(YoQueSe());
    }

    IEnumerator YoQueSe()
    {
        yield return new WaitForSeconds(0.2f);
        if(XRrig.position != comprovar)
            steps.Play();
        comprovar = XRrig.position;
    }
}
