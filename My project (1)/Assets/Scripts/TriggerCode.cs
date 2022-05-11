using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCode : MonoBehaviour
{
    [SerializeField] private string name;
    public Performance performance;
    [SerializeField] private bool unLoadFirstPuzzle;
    // Start is called before the first frame update
    void Start()
    {
        name = gameObject.name;
        unLoadFirstPuzzle = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(name == "CubeLocateSecondPuzzle")
        {
            unLoadFirstPuzzle=true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enterd");
        if(other.tag == "Controller" && unLoadFirstPuzzle)
        {
            Debug.Log("Enter to colliders");
            performance.unLoadFirstPuzzle = true;
            unLoadFirstPuzzle = false;
        }
    }
}
