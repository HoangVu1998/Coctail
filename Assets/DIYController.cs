using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class DIYController : MonoBehaviour
{
    public static DIYController instance;
    public GameObject DIY;
    public List<characterUI> characterDIY;
    public GameObject UI;
    public bool DIYMove;
    public bool DIYRotate;
    public bool isMan4;
    public bool isMan5;
    public bool isMan7;
    public bool isDIY;
    public GameObject BG;
    //các GamePlay Defult.
    public GameObject MainGameDIY;
    public GameObject ModalDefult;
    public GameObject ModalDefultClone;
    public GameObject ModalDIY;
    //quản lý hoa quả.


    private void Awake()
    {
        instance = this;
        DIYMove = false;
        DIYRotate = false;
        isMan4 = false;
        isMan5 = false;
        isMan7 = false;
    }
    public void startDIY()
    {
        isDIY = false;
        DIY.SetActive(true);
    }
    public void OnClickBackToUI()
    {
        foreach (Transform child in DIYMain.instance.Panelman2.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        DIYMain.instance.modalCloneList.Clear();
        UI.SetActive(true);
        DIY.SetActive(false);
    }
    public void DIybackToStep4()
    {
    }
    public void DIybackToStep5()
    {
        DIYMain.instance.DIybackToStep5();
        BG.SetActive(false);
    }
    public void DIybackToStep6()
    {
        isMan5 = false;
        DIYMain.instance.Man5DIY.SetActive(false);
        DIYMain.instance.Man6DIY.SetActive(true);
        DIYMain.instance.ImageMan6DIY.sprite = characterDIY[UIManager.Instance.CharacterType].CharacterUI[DIYMain.instance.Indexer];
    }
    public void DIybackToStep7()
    {
        DIYButtonToping.instace.CreatFutits();
        BG.SetActive(true);
        DIYMain.instance.DIybackToStep7();
        MainGameDIY.SetActive(true);
        MainGameController.instance.spriteRendererMain.sprite = characterDIY[UIManager.Instance.CharacterType].CharacterModal[DIYMain.instance.Indexer];
        var a = Instantiate(MainGameController.instance.ModalDefult);
        a.transform.SetParent(DIYMain.instance.SaveModalDIY);
        isMan7 = true;
        isDIY = false;
    }
    public void DIybackToStep1()
    {
        foreach (Transform child in DIYMain.instance.SaveModalDIY.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        DIYMain.instance.DIybackToStep1();
        MainGameDIY.SetActive(false);
        DestroyGamer.destroynow = true;
        isMan7 = false;
        isDIY = true;
        DIYMain.instance.CountFurits= 0;    
    }
}


