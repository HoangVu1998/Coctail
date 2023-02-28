using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ModalBuoyancyEffector : MonoBehaviour
{
    BuoyancyEffector2D effector;
    public float NumbereffectorUp = 0.02f;
    public float NumbereffectorDown = 0.02f;

    public float MaxhightSurFace;
    public float MinhightSurFace;

    public float MaxlowMagnitude;
    public float MinlowMagnitude;
    private void Start()
    {
        effector = GetComponent<BuoyancyEffector2D>();
    }
    void Update()
    {
        Vector3 acceleration = Input.acceleration;

        if (acceleration.y < 0 && ModalMove.isFiling == true)
        {
            if (acceleration.x >= 0.4 && acceleration.x <= 1 || acceleration.x >= -1 && acceleration.x <= -0.4)
            {
                effector.surfaceLevel -= NumbereffectorDown;
                if (effector.surfaceLevel < MinhightSurFace)
                {
                    NumbereffectorUp = 0.01f;
                    NumbereffectorDown = 0;
                }
            }
            if (acceleration.x >= 0 && acceleration.x < 0.4 || acceleration.x >= -0.4 && acceleration.x < 0)
            {
                effector.surfaceLevel += NumbereffectorUp;
                if (effector.surfaceLevel > MaxhightSurFace)
                {
                    NumbereffectorUp = 0;
                    NumbereffectorDown = 0.01f;
                   
                }
            }
            effector.flowMagnitude = 0;
        }
        if (acceleration.y >= 0 && ModalMove.isFiling == true)
        {
            //if (acceleration.x >= 0.9 && acceleration.x <= 1 || acceleration.x >= -1 && acceleration.x <= -0.9)
            //{

            //    if (effector.surfaceLevel >= MaxhightSurFace)
            //    {
            //        NumbereffectorUp = 0.01f;
            //        NumbereffectorDown = 0;
            //    }
            //    effector.surfaceLevel -= NumbereffectorDown;
            //}
            if ( acceleration.x <= 1f && acceleration.x > 0)
            {
                effector.flowMagnitude = MaxlowMagnitude;
            }
            if (acceleration.x >= -1f && acceleration.x < 0)
            {
                effector.flowMagnitude = MinlowMagnitude;
            }
        }
      
        
    }
}
