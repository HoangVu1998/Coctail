using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameDIY : MainGame
{
    void Update()
    {
        if (LevelController.isShake == true)
        {
            gameObject.SetActive(true);
            //var a = Instantiate(MainGameController.instance.ModalDefult);
            //LevelController.isShake = false;
            //if (DetectShake.uonghet == true)
            //{
            //    Destroy(a);
            //}
        }
    }
}
