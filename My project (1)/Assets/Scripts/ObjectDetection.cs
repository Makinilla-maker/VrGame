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
        Debug.Log(other.gameObject.name);
        if(other.gameObject.tag != "Controller")    droppedItemsList.Add(other.gameObject);
        if(other.gameObject.tag == "Tape")  TimeForGo(1);
     
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name);
        if(other.gameObject.tag != "Controller")    other.gameObject.SetActive(false);
    }
    private void TimeForGo(int id)
    {
        //effecto de camera VHS
        //tp a escena
        GameObject.Find("XRRig").gameObject.transform.position = new Vector3(-22.5799999f,-0.430000007f,10.5200005f);
    }
}
