using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DIYMain : MonoBehaviour
{
    public static DIYMain instance;
    public Transform Panel1;
    public Transform Panelman2;

    public GameObject CocDefult;
    public GameObject ModalDIY;
    protected SpriteRenderer spriteRendererDIY;
    public GameObject Man2DIY;
    public GameObject Man3DIY;



    GameObject ModalDYE;
    public List<GameObject> modalDIYclone;
    public List<GameObject> modalCloneList;
    public List<GameObject> NewmodalCloneList;
    public int Indexer;


    DIYController DIYController;
    Image ImageCocDefult;
    private void Awake()
    {
        instance = this;
        // Tìm đối tượng con có tên là Modal
        Transform childTransformMain = ModalDIY.transform.GetChild(0).Find("ModalDIY");
        // thay sprite của đối tượng modalDufalt của modal nguyên thủy
        spriteRendererDIY = childTransformMain.GetComponent<SpriteRenderer>();
        // Tìm đối tượng DIYController trên cảnh
        GameObject GameOBJ = GameObject.Find("DIYController");
        // Lấy thành phần "DIYController" từ đối tượng
        DIYController = GameOBJ.GetComponent<DIYController>();
        ImageCocDefult = CocDefult.GetComponent<Image>();
    }
    public void BackToStartGame()
    {
        foreach (Transform child in Panelman2.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
    public void DIybackToStep2()
    {
        foreach (var Image in DIYController.instance.characterDIY[UIManager.Instance.CharacterType].CharacterUI)
        {
            ImageCocDefult.sprite = Image;
            ModalDYE = Instantiate(CocDefult, Panelman2);
            modalDIYclone.Add(ModalDYE);
            modalCloneList.Add(ModalDYE);
            ModalDYE.transform.SetParent(Panelman2);
        }
    }
    public void DIybackToStep3()
    {
        Man2DIY.SetActive(false);
        Man3DIY.SetActive(true);
        spriteRendererDIY.sprite = DIYController.instance.characterDIY[UIManager.Instance.CharacterType].CharacterModal[Indexer];
        Instantiate(ModalDIY);
    }

    public void DIybackToStep4()
    {
        Man2DIY.SetActive(false);
        Man3DIY.SetActive(true);
        spriteRendererDIY.sprite = DIYController.instance.characterDIY[UIManager.Instance.CharacterType].CharacterModal[Indexer];
        Instantiate(ModalDIY);
    }
}