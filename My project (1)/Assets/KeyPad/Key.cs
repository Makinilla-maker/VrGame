using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor.UIElements;
public class Key : MonoBehaviour
{
    public bool keyHit = false;
    public GameObject[] allButtons;
    public TextMeshProUGUI textDisplay;
    private Color originalColor;
    private Renderer renderer;
    public DoorLvl1AnimationController anim;
    public int i;

    public char[] pas = new char[] {'0','0','0','0'};
    public char[] correctPas = new char[] {'2','8','4','5'};
    private float colorReturnTime = 0.1f;
    private float returnColor;
    public string s;
    // Start is called before the first frame update
    void Start()
    {
        s = new string(pas);
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        textDisplay.text = s;
        if(keyHit&&returnColor<Time.time)
        {
            returnColor = Time.time+colorReturnTime;
            renderer.material.color = Color.green;
            keyHit = false;
        }
        if(renderer.material.color != originalColor && returnColor<Time.time)
        {
            renderer.material.color = originalColor;
        }
        if(i == 3)
        {
            CheckPassword();
        }
    }

    public void CheckPassword()
    {
        int g = 0;
        for (int j=0;j<pas.Length;j++) 
        {      
            if (pas[j] == correctPas[j]) 
            {
                g++;
            }
            else
            {
                j=3;
            }
        }
        if (g == pas.Length) 
        {
            char[] l = new char[] {'c','o','r','r','e','c','t','!'};
            RestartButtonColor();
            s = new string(l);
            g = 0;
            i = 0;
            anim.start = true;
            anim.audio.Play();
        }
        else 
        {   
            for(int k = 0; k < pas.Length; k++)
            {
                pas[k] = '0';
            }
           RestartButtonColor();
            char[] l = new char[] {'0','0','0','0'};
            s = new string(l);
            i = -1; 
        }
    }

    void RestartButtonColor()
    {
    for(int a = 0; a < 8; a++)
        {
            allButtons[a].GetComponent<Renderer>().material.color = allButtons[a].GetComponent<HandButton>().startColor;
        }
    }
}
