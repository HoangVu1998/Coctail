using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuritsDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LimitFurits"))
        {
            Destroy(gameObject);  
        }
    }
    private void Update()
    {
        if(DetectShake.uonghet == true || DestroyGamer.destroynow)
        {
            Destroy(gameObject);
        }
    }
}
