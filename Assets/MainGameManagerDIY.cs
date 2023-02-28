using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManagerDIY : MonoBehaviour
{
    public GameObject[] DIY;
    public GameObject StartGame;
    public GameObject MainGame;
    public void onClickDiyBeer()
    {
        DIY[0].SetActive(true);
        StartGame.SetActive(false);
        MainGame.SetActive(false);  
    }
}
