using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBell : MonoBehaviour
{
    public Transform playerBody;
    public Vector3 offSet;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        transform.position = playerBody.position + Vector3.up * offSet.y
        + Vector3.ProjectOnPlane(playerBody.right,Vector3.up).normalized * offSet.x
        + Vector3.ProjectOnPlane(playerBody.forward,Vector3.up).normalized * offSet.z;
        transform.eulerAngles = new Vector3(0,playerBody.eulerAngles.y,0);
    }
}
