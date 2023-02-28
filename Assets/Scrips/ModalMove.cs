using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class ModalMove : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform targetRight;
    public Transform targetLeft;

    public Transform TargetRightTop;
    public Transform TargetLeftTop;

    public Transform TargetOriganal;

    public Transform TargetLeftHorizontal;
    public Transform TargetRightHorizontal;

    public float stoppingDistance = 0.1f;  // khoảng cách dừng lại


    bool IstargetRight;
    // bool IsTargetRightHorizontal;

    bool IstargetLeft;
    //bool IsTargetLeftHorizontal;

    public static bool isFiling;
    private void Start()
    {
        isFiling = false;

        //right
        IstargetRight = false;
        //IsTargetRightHorizontal = false;

        //left
        IstargetLeft = false;
        // IsTargetLeftHorizontal = false;

    }
    void Update()
    {

        if (isFiling == false)
        {
            modalMoveBefore();
        }
        if (isFiling == true)
        {
            modalMoveAfter();
        }
    }
    public void modalMoveBefore()
    {
        moveToWards(TargetOriganal);
        if (Vector2.Distance(transform.position, TargetOriganal.position) < 0.01f)
        {
            isFiling = true;
        }
    }
    public void modalMoveAfter()
    {
        Vector3 acceleration = Input.acceleration;
        if (acceleration.y < 0)
        {
            //Angle positive
            if (acceleration.x >= 0.5 && acceleration.x < 1 && IstargetRight == false)
            {
                moveLerp(targetRight);
                Debug.Log("Istarget1");
                if (transform.position.y < targetRight.position.y)
                {
                    IstargetRight = true;
                }
            }
            if (acceleration.x > -1 && acceleration.x <= -0.5 && IstargetLeft == false)
            {
                moveLerp(targetLeft);
                if (transform.position.y < targetLeft.position.y)
                {
                    IstargetLeft = true;
                }
            }
        }
        else
        {
            {
                //Angle positive
                if (acceleration.x >= 0.7f && acceleration.x < 1 /*&& IsTargetRightHorizontal == false*/)
                {
                    moveLerp(TargetRightHorizontal);
                    Debug.Log("Istarget2");
                    //if (transform.position.y < TargetRightHorizontal.position.y)
                    //{
                    //    IsTargetRightHorizontal = true;
                    //}
                }
                if (acceleration.x >= 0f && acceleration.x < 0.7f)
                {
                    moveLerp(TargetRightTop);
                    //Debug.Log("Istarget3");
                }
                //Angle negative
                if (acceleration.x >= -1 && acceleration.x < -0.7 /*&& IsTargetLeftHorizontal == false*/)
                {
                    moveLerp(TargetLeftHorizontal);
                    //if (transform.position.y < TargetLeftHorizontal.position.y)
                    //{
                    //    IsTargetLeftHorizontal = true;
                    //}
                }
                if (acceleration.x >= -0.7f && acceleration.x <= 0f)
                {
                    moveLerp(TargetLeftTop);
                }
            }
        
    }
}
    public void moveLerp(Transform target)
    {
        transform.position = Vector3.Lerp(transform.position, target.position, 0.8f * Time.deltaTime);
    }
    public virtual void moveToWards(Transform target)
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, Time.deltaTime);
    }
}
