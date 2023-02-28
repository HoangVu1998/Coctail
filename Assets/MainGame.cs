using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public Transform Content;
    private void Awake()
    {
        MainGameController.instance.Content = Content;
    }
    private void Update()
    {
        if (LevelController.isShake == true)
        {
            var a = Instantiate(MainGameController.instance.ModalDefult);
            LevelController.isShake = false;
            if (DetectShake.uonghet == true)
            {
                Destroy(a);
            }
        }
    }
}
