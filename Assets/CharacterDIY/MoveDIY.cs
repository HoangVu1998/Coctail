using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDIY : ModalMove
{
    void Update()
    {
        if(Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            modalMoveBefore();
        }
    }
}
