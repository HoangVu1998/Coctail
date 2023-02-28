using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class RotateGamer : MonoBehaviour
{
    public float rotationSpeed = 4f;

    float newRotation;
    public static Transform oldParentTranform;
    public float testAngle = 20;
    private void Start()
    {
        oldParentTranform = transform;
    }
    void Update()
    {
        Rotate();
    }
    public void Rotate()
    {
        Vector3 acceleration = Input.acceleration;
        if (ModalMove.isFiling == true)
        {
            if (acceleration.y < 0)
            {
                //Angle positive
                if (acceleration.x > -0.15 && acceleration.x < 0.15)
                {
                    Rotate1(0);
                }
                if (acceleration.x >= 0.15 && acceleration.x < 0.2)
                {
                    Rotate1(10);
                }
                if (acceleration.x >= 0.2 && acceleration.x < 0.4)
                {
                    Rotate1(20);
                }
                if (acceleration.x >= 0.4 && acceleration.x < 0.5)
                {
                    Rotate1(30);
                }
                if (acceleration.x >= 0.5 && acceleration.x < 0.7)
                {
                    Rotate1(30);
                }
                if (acceleration.x >= 0.7 && acceleration.x < 0.8)
                {
                    Rotate1(40);
                }
                if (acceleration.x >= 0.8 && acceleration.x < 1)
                {
                    Rotate1(50);
                }
                // Angle negative
                if (acceleration.x >= -0.2 && acceleration.x < -0.15)
                {
                    Rotate1(-10);
                }
                if (acceleration.x >= -0.4 && acceleration.x < -0.2)
                {
                    Rotate1(-20);
                }
                if (acceleration.x >= -0.5 && acceleration.x < -0.4)
                {
                    Rotate1(-20);
                }
                if (acceleration.x >= -0.7 && acceleration.x < -0.5)
                {
                    Rotate1(-30);
                }
                if (acceleration.x >= -0.8 && acceleration.x < -0.7)
                {
                    Rotate1(-40);
                }
                if (acceleration.x >= -1 && acceleration.x < -0.8)
                {
                    Rotate1(-50);
                }
            }
            // Y > 0
            else
            {
                //Angle positive
                if (acceleration.x >= 0 && acceleration.x < 0.2)
                {
                    Rotate1(180);
                }
                if (acceleration.x >= 0.2 && acceleration.x < 0.4)
                {
                    Rotate1(175);
                }
                if (acceleration.x >= 0.4 && acceleration.x < 0.5)
                {
                    Rotate1(170);
                }
                if (acceleration.x >= 0.5 && acceleration.x < 0.6)
                {
                    Rotate1(160);
                }
                if (acceleration.x >= 0.6 && acceleration.x < 0.7)
                {
                    Rotate1(150);
                }
                if (acceleration.x >= 0.7 && acceleration.x < 0.8)
                {
                    Rotate1(140);
                }
                if (acceleration.x >= 0.8 && acceleration.x < 1)
                {
                    Rotate1(130);
                }
                // Angle negative
                if (acceleration.x >= -0.2 && acceleration.x < 0)
                {
                    Rotate1(-180);
                }
                if (acceleration.x >= -0.4 && acceleration.x < -0.2)
                {
                    Rotate1(-175);
                }
                if (acceleration.x >= -0.5 && acceleration.x < -0.4)
                {
                    Rotate1(-170);
                }
                if (acceleration.x >= -0.6 && acceleration.x < -0.5)
                {
                    Rotate1(-160);
                }
                if (acceleration.x >= -0.7 && acceleration.x < -0.6)
                {
                    Rotate1(-150);
                }
                if (acceleration.x >= -0.8 && acceleration.x < -0.7)
                {
                    Rotate1(-140);
                }
                if (acceleration.x >= -1 && acceleration.x < -0.8)
                {
                    Rotate1(-130);
                }
            }
        }
    }
    public void Rotate1(float targetRotation)
    {
        //vị trí hiện tại của obj
        float currentRotation = transform.localRotation.eulerAngles.z;
        //làm mượt góc
        newRotation = Mathf.LerpAngle(currentRotation, targetRotation, Time.deltaTime * rotationSpeed);
        // xoay với góc đó
        transform.localRotation = Quaternion.Euler(0, 0, newRotation);
    }
}




