using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalDIYController : MonoBehaviour
{
    public static ModalDIYController instance;
    
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }
   
}
