using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    Rigidbody2D Rigidbody2D;
    public float speed = 2;
    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();  
    }
    private void Update()
    {
        Rigidbody2D.velocity = Vector3.right * Time.deltaTime * speed ; 
    }
}
