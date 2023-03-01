using System;
using System.Collections;
using System.Collections.Generic;
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

    public GameObject MainGameDIY;
    public GameObject ModalDIY;

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
        foreach (var Intemr in DIYMain.instance.modalCloneList)
        {
            DestroyImmediate(Intemr);
        }
        foreach (var Intemr in DIYMain.instance.NewmodalCloneList)
        {
            DestroyImmediate(Intemr);
            Debug.Log(DIYMain.instance.NewmodalCloneList.Count);
        }
        UI.SetActive(true);
        DIY.SetActive(false);
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
        BG.SetActive(true);
        DIYMain.instance.DIybackToStep7();
        MainGameDIY.SetActive(true);
        //isMan7= true;
        isDIY = false;
    }
}

