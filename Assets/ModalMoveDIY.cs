using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalMoveDIY : ModalMove
{
    public bool  isTutorialMove;


    private void Start()
    {
        isTutorialMove = true;
    } 
    void Update()
    {
        Vector3 acceleration = Input.acceleration;

        if (isFiling == false && isTutorialMove) // Chỉ di chuyển nếu đối tượng đang trong trạng thái di chuyển và chưa đến vị trí đích
        {
            moveToWards(TargetOriganal);
            if (Vector2.Distance(transform.position, TargetOriganal.position) < 0.01f)
            {
                isFiling = true;
            }
        }
        // Kiểm tra nếu chạm vào màn hình và đối tượng đến vị trí đích rồi thì không di chuyển nữa
        if ((Input.touchCount > 0|| Input.GetMouseButton(1)) && Vector2.Distance(transform.position, TargetOriganal.position) >= 0.01f)
        {
            isTutorialMove = true;
        }
        else
        {
            isTutorialMove = false;
        }
    }
    public override void moveToWards(Transform target)
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, Time.deltaTime);
    }
}
