using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ModalCollision : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (ModalMove.isFiling == true)
        {
            if (collision.gameObject.CompareTag("1"))
            {
                DetectShake.uonghet = true;
            }
        }
    }
}
