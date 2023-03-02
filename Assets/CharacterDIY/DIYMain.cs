using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DIYMain : MonoBehaviour
{
    public static DIYMain instance;
    //vị trí luư obj
    public Transform Panel1;
    public Transform Panelman2;
    public Transform SaveModalDIY;

    //Modal và cốc nguyên thủy
    public GameObject ModalDefult;
    public GameObject CocDefult;
    public GameObject ModalDIY;
    public GameObject ModalClone;

    protected SpriteRenderer spriteRendererDIY;
    //level
    public GameObject Man2DIY;
    public GameObject Man3DIY;
    public GameObject Man4DIY;
    public GameObject Man5DIY;
    public GameObject Man6DIY;
    public Image ImageMan6DIY;
    public GameObject Man7DIY;
    //list Furits được tạo ta
    public List<GameObject> listFuritsDIY = new List<GameObject>();

    public bool BoolcountFurits;

    public Transform Content;

    public int CountFurits;


    GameObject ModalDYE;
    public List<GameObject> modalDIYclone;
    public List<GameObject> modalCloneList;
    public List<GameObject> NewmodalCloneList;

    //Indexer lưu vị trí của cốc list
    public int Indexer;


    public DIYController DIYControllerClone;
    Image ImageCocDefult;
    private void Awake()
    {
        CountFurits = 0;
        instance = this;
        // Tìm đối tượng con có tên là Modal
        Transform childTransformMain = ModalDIY.transform.GetChild(0).Find("ModalDIY");
        // thay sprite của đối tượng modalDufalt của modal nguyên thủy
        spriteRendererDIY = childTransformMain.GetComponent<SpriteRenderer>();
        // Tìm đối tượng DIYController trên cảnh
        GameObject GameOBJ = GameObject.Find("DIYController");
        // Lấy thành phần "DIYController" từ đối tượng
        DIYControllerClone = GameOBJ.GetComponent<DIYController>();
        ImageCocDefult = CocDefult.GetComponent<Image>();
    }
    private void Start()
    {
        CountFurits = 0;
        BoolcountFurits = false;
    }
    private void Update()
    {
        DIybackToStep4();

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
        foreach (var Image in DIYControllerClone.characterDIY[UIManager.Instance.CharacterType].CharacterUI)
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
        spriteRendererDIY.sprite = DIYControllerClone.characterDIY[UIManager.Instance.CharacterType].CharacterModal[Indexer];
        ModalClone = Instantiate(ModalDIY);
        ModalClone.transform.SetParent(SaveModalDIY);
        ModalClone.SetActive(true);
    }

    public void DIybackToStep4()
    {

        if (DIYControllerClone.isMan4)
        {
            Man4DIY.SetActive(true);
            DIYControllerClone.MainGameDIY.SetActive(true);
            DIYControllerClone.BG.SetActive(false);
            DIYButtonToping.instace.ResetScores();  
            foreach (var topping in DIYControllerClone.characterDIY[UIManager.Instance.CharacterType].DIYImageButtonTopping)
            {
                GameObject toppingSpawn = Instantiate(topping, Content);
                toppingSpawn.transform.SetParent(Content);
            }
            DIYControllerClone.isMan4 = false;
        }
        if (CountFurits == 15 && BoolcountFurits == false)
        {
            DIYControllerClone.isDIY = true;
            BoolcountFurits = true;
            CountFurits = 0;
            Man5DIY.SetActive(true);
            Man3DIY.SetActive(false);
            //quan lý modal
            DIYControllerClone.MainGameDIY.SetActive(false);
            Destroy(ModalClone);
            DIYControllerClone.isMan4 = false;
            DIYControllerClone.isMan5 = true;
        }
    }
    public void DIybackToStep5()
    {
        Man5DIY.SetActive(false);
        Man6DIY.SetActive(true);
    }
    public void DIybackToStep6()
    {
        ImageMan6DIY.sprite = DIYControllerClone.characterDIY[UIManager.Instance.CharacterType].CharacterUI[Indexer];
    }
    public void DIybackToStep7()
    {
        Man6DIY.SetActive(false);
    }
}