using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool keyHit = false;
    private Color originalColor;
    private Renderer renderer;
    private float colorReturnTime = 0.1f;
    private float returnColor;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
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
