using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public float timer;
    public GameObject door;
    public bool roomActivated;
    // Start is called before the first frame update
    void Start()
    {
        timer = 5;
        roomActivated = false;
    }
    void Update()
    {
        if(roomActivated)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                SceneManager.LoadScene("Credits");
            }
        }  
    }

    // Update is called once per frame
    public void ResetGame()
    {
        Debug.Log("is entered");
        door.SetActive(true);
        roomActivated = true;
    }
}
