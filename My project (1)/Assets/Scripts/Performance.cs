using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Performance : MonoBehaviour
{
    public bool loadAsylum;
    public bool unLoadFirstPuzzle;
    public bool unLoadSecondPuzzle;
    private bool firstRoomLoadOneTime;
    public GameObject puzzleFirstRoom;
    public GameObject wallToBlockFirstPuzzle;
    public GameObject wallToBlockSecondPuzzle;
    public GameObject puzzleSecondRoom;
    // Start is called before the first frame update
    void Start()
    {
        puzzleFirstRoom.gameObject.SetActive(false);
        puzzleSecondRoom.gameObject.SetActive(false);
        firstRoomLoadOneTime = false;
        wallToBlockFirstPuzzle.SetActive(false);
        wallToBlockSecondPuzzle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(loadAsylum && !firstRoomLoadOneTime)
        {
            puzzleFirstRoom.gameObject.SetActive(true);
            puzzleSecondRoom.gameObject.SetActive(true);
            firstRoomLoadOneTime = true;
        }
        if(unLoadFirstPuzzle)
        {
            wallToBlockFirstPuzzle.SetActive(true);
            puzzleFirstRoom.SetActive(false);
        }
        if (unLoadSecondPuzzle)
        {
            wallToBlockSecondPuzzle.SetActive(true);
            puzzleSecondRoom.SetActive(false);
        }
    }
}
