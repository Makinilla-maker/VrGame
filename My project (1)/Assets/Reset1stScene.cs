using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Reset1stScene : MonoBehaviour
{
    // Start is called before the first frame update   
    public float timer;
    void Start()
    {
        timer = 75;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        } 
    }
}
