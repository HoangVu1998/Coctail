using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FrameRotate : MonoBehaviour
{
    // Declare a reference to the Rotate script
    RotateGamer rotateScript;
    // Use this for initialization
    void Start()
    {
        // Get the reference to the Rotate script on the parent object
        rotateScript = transform.parent.GetComponent<RotateGamer>();
    }

    void Update()
    {
        // Get the position of the object with the Rotate script
        Vector3 rotatePosition = rotateScript.transform.position;

        // Use the position to calculate the rotation angle
        transform.Rotate(0, 0, rotatePosition.z);
    }
}

