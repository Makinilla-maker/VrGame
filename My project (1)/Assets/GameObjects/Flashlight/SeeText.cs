using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeText : MonoBehaviour
{
    public List<GameObject> textInWalls = new List<GameObject>();
    private GameObject[] texts;
    public Transform flashLightFront;
    public float visionAngle;
    // Start is called before the first frame update
    void Start()
    {
        texts = GameObject.FindGameObjectsWithTag("WallText");
        foreach (GameObject text in texts)
        {
            textInWalls.Add(text);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
