using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetection : MonoBehaviour
{
    public List<GameObject> droppedItemsList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Controller")    droppedItemsList.Add(other.gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name);
        if(other.gameObject.tag == "Controller")    other.gameObject.SetActive(false);
    }
}
