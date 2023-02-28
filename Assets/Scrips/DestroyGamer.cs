using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGamer : MonoBehaviour
{
    public static bool destroynow;
    private void Start()
    {
        destroynow = false; 
    }
    void Update()
    {
        if(DetectShake.uonghet == true || destroynow==true)
        {
            Destroy(gameObject);
        }
    }
}
