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
    public FadeScreen fadeScreen;
    public GameObject news;
    public Environment audioS;
    // Start is called before the first frame update
    void Awake()
    {
        if(SceneManager.GetActiveScene().ToString() != "IntroScene")
        {
            news.SetActive(false);
            roomF.SetActive(false);
        }
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
                StartCoroutine(TimeForGo(1));
            }
            else
            {
                StartCoroutine(GoTOScreneRoutine());                
            }
        }
     
    }
    IEnumerator GoTOScreneRoutine()
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);
        SceneManager.LoadScene("SampleScene");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name);
        if(other.gameObject.tag != "Controller")    other.gameObject.SetActive(false);
    }
    IEnumerator TimeForGo(int id)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);
        GameObject.Find("XRRig").gameObject.transform.position = newPos.position;
        fadeScreen.FadeIn();
        performance.loadAsylum = true;
        news.SetActive(true);
        //radioAudio.Play();
        audioS.SetAudioClip(0);
        Destroy(room);
        //room.SetActive(false);
    }
}
