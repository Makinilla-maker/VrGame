using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public AudioClip dinningRoom;
    public AudioClip hallway;
    public AudioClip dayRoom;
    public AudioSource envionmentSource;

    public void Reproduce()
    {
        envionmentSource.Play();
    }
    public void SetAudioClip(int state)
    {
        switch(state)
        {
            case 0:
                envionmentSource.clip = dinningRoom;
                break;
            case 1:
                envionmentSource.clip = hallway;
                break;
            case 2:
                envionmentSource.clip = dayRoom;
                break;
            default:
                break;
        }
        Reproduce();
    }
}
