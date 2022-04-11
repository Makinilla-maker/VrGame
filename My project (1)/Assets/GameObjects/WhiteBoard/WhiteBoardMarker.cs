using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class WhiteBoardMarker : MonoBehaviour
{
    [SerializeField] private Transform tip;
    [SerializeField] private int penSize = 5;

    private Renderer _renderer;
    private Color[] _colors;
    public float tipHeight;

    private RaycastHit touch;
    private WhiteBoard whiteboard;
    private Vector2 touchPos;
    private bool touchedLastFrame;
    private Vector2 lastTouchPos;
    private Quaternion lastTouchRot;


    // Start is called before the first frame update
    void Start()
    {
        _renderer = tip.GetComponent<Renderer>();
        _colors = Enumerable.Repeat(_renderer.material.color, penSize * penSize).ToArray();
        //tipHeight = tip.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        Draw();
    }

    private void Draw()
    {
        if(Physics.Raycast(tip.position,-transform.forward,out touch, tipHeight))
        {
            if(touch.transform.CompareTag("Whiteboard"))
            {
                if(whiteboard == null)
                {
                    whiteboard = touch.transform.GetComponent<WhiteBoard>();
                }

                touchPos = new Vector2(touch.textureCoord.x, touch.textureCoord.y);

                var x = (int)(touchPos.x * whiteboard.textureSize.x - (penSize/2));
                var y = (int)(touchPos.y * whiteboard.textureSize.y - (penSize/2));

                if(y < 0 || y > whiteboard.textureSize.y || x < 0|| x > whiteboard.textureSize.x) return;

                if(touchedLastFrame)
                {
                    whiteboard.texture.SetPixels(x,y,penSize,penSize,_colors);

                    for(float f = 0; f < 1.0f; f += 0.03f)
                    {
                        var lerpX = (int)Mathf.Lerp(lastTouchPos.x,x,f); 
                        var lerpY = (int)Mathf.Lerp(lastTouchPos.y,y,f);
                        whiteboard.texture.SetPixels(lerpX,lerpY,penSize,penSize,_colors);
                    }
                    transform.rotation = lastTouchRot;
                    
                    whiteboard.texture.Apply();
                }
                
                lastTouchPos = new Vector2(x,y);
                lastTouchRot = transform.rotation;
                touchedLastFrame = true;
                return;
            }
        }

        whiteboard = null;
        touchedLastFrame = false;
    }
}
