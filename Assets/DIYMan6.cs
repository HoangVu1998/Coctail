using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DIYMan6 : DIYMain
{
    public Image ImageDefult;
    void Start()
    {
        ImageDefult.sprite = spriteRendererDIY.sprite = DIYController.instance.characterDIY[UIManager.Instance.CharacterType].CharacterModal[Indexer];
        Debug.Log(ImageDefult);
    }

}
