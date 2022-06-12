using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public float timer;
    public GameObject door;
    public bool roomActivated;
    public bool a;
    public GameObject news;
    public AudioSource ass;
    // Start is called before the first frame update
    void Start()
    {
        timer = 5;
        roomActivated = false;
        a = true;
    }
    void Update()
    {
        if(roomActivated)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                SceneManager.LoadScene("Credits");
                news.SetActive(false);
            }
        }  
    }

    // Update is called once per frame
    public void ResetGame()
    {
        Debug.Log("is entered");
        door.SetActive(true);
        if(a)
            ass.Play();
        a = false;
        roomActivated = true;
    }
}
