using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;
using static UnityEngine.GraphicsBuffer;

public class MoveFurits : MonoBehaviour
{
   Rigidbody2D Rigidbody2D;
    private void Start()
    {
        Rigidbody2D=GetComponent<Rigidbody2D>();    
    }
    void Update()
    {
        Vector3 acceleration = Input.acceleration;
        if (acceleration.y >= 0 && ModalMove.isFiling == true && acceleration.x < 0.9f && acceleration.x > 0)
        {
            Rigidbody2D.gravityScale = -1.5f;
        }
        if (acceleration.y >= 0 && ModalMove.isFiling == true && acceleration.x > -0.9f && acceleration.x < 0)
        {
            Rigidbody2D.gravityScale = -1.5f;
        }
        if (acceleration.y < 0)
        {
            Rigidbody2D.gravityScale = 1;
        }
    }
}



