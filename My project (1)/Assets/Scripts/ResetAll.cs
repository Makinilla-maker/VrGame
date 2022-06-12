using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAll : MonoBehaviour
{
    public Key key;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Controller" && other.GetType() == typeof(BoxCollider))
        {
            audio.Play();
            for (int i = 0; i < key.pas.Length; i++)
            {
                key.pas[i] = '0';
            }
            key.s = "0000";
            key.i = -1;
            key.RestartButtonColor();
        }
    }
}
