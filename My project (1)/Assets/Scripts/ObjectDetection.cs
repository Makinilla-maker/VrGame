using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectDetection : MonoBehaviour
{
    public List<GameObject> droppedItemsList = new List<GameObject>();
    public Transform newPos;
    public GameObject room;
    public GameObject roomF;
    public Performance performance;
    public AudioSource radioAudio;
    // Start is called before the first frame update
    void Awake()
    {
        if(SceneManager.GetActiveScene().ToString() != "IntroScene")
            roomF.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.tag != "Controller")    droppedItemsList.Add(other.gameObject);
        if (other.gameObject.tag == "Tape")
        {
            Debug.Log(SceneManager.GetActiveScene().name);
            if (SceneManager.GetActiveScene().name != "IntroScene")
            {
                TimeForGo(1);
            }
            else
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
     
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
        GameObject.Find("XRRig").gameObject.transform.position = newPos.position;
        performance.loadAsylum = true;
        radioAudio.Play();
        Destroy(room);
        //room.SetActive(false);
    }
}
