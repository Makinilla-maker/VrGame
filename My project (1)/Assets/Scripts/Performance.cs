using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Performance : MonoBehaviour
{
    public bool loadAsylum;
    private bool firstRoomLoadOneTime;
    public GameObject puzzleFirstRoom;
    // Start is called before the first frame update
    void Start()
    {
        puzzleFirstRoom.gameObject.SetActive(false);
        firstRoomLoadOneTime = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(loadAsylum && !firstRoomLoadOneTime)
        {
            puzzleFirstRoom.gameObject.SetActive(true);
            firstRoomLoadOneTime = true;
        }
    }
}
