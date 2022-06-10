using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steps : MonoBehaviour
{
    public AudioSource steps;

    public void FootSteps()
    {
        steps.Play();
    }
}
