using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDIY : ModalMove
{
    DIYController DIYControllerClone;
    public static MoveDIY instance;
    private void Awake()
    {
        instance= this; 
        GameObject GameOBJ = GameObject.Find("DIYController");
        // Lấy thành phần "DIYController" từ đối tượng
        DIYControllerClone = GameOBJ.GetComponent<DIYController>();
    }
    void Update()
    {
        if( Input.GetMouseButton(0) && !isFiling)
        {
            modalMoveBefore();
        }
        if (DIYController.instance.isMan7)
        {
            modalMoveAfter();
        }
    }
    public override void modalMoveBefore()
    {
        moveToWards(TargetOriganal);
        if (Vector2.Distance(transform.position, TargetOriganal.position) < 0.01f)
        {
            isFiling = true;
            DIYControllerClone.isMan4 = true;
        }
    }
}
