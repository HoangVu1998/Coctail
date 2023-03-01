using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDIY : RotateGamer
{
    private void Update()
    {
        if (DIYController.instance.isMan7)
        {
            Rotate();
        }
    }
}
