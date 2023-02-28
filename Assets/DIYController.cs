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
    public GameObject MainGameDIY;

    public GameObject ModalDIY;

    private void Awake()
    {
        instance = this;
        DIYMove = false;
        DIYRotate = false;
        isMan4 = false;

    }
    public void startDIY()
    {
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

}

