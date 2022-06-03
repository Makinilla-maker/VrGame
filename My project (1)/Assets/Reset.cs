using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private bool resetReady;
    // Start is called before the first frame update
    void Start()
    {
        resetReady = false;
    }

    // Update is called once per frame
    void ResetGame()
    {
        if(resetReady)
        {
            //Codigo de reseteo.
        }
    }
}
