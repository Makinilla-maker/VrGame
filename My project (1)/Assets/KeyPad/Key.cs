using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor.UIElements;
public class Key : MonoBehaviour
{
    public bool keyHit = false;

    public TextMeshProUGUI textDisplay;
    private Color originalColor;
    private Renderer renderer;
    public int i = 0;

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
    }
}