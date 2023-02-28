using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameController : MonoBehaviour
{
    public static MainGameController instance;
    public GameObject MainGame;
    public GameObject ModalDefult;
    protected SpriteRenderer spriteRendererMain;
    public List<characterUI> characterUI;

    public Transform Content;

    private void Awake()
    {
        instance = this;
        // Tìm đối tượng con có tên là Modal
        Transform childTransformMain = ModalDefult.transform.GetChild(0).Find("Modal");
        // thay sprite của đối tượng modalDufalt của modal nguyên thủy
        spriteRendererMain = childTransformMain.GetComponent<SpriteRenderer>();
    }
    public void StartMainGame()
    {
        MainGame.SetActive(true);
        spriteRendererMain.sprite = characterUI[UIManager.Instance.CharacterType].CharacterModal[UIManager.Instance.IndexerCharacterType];
        // tạo ra các button bấm chọn topping beer - nằm dưới content
        foreach (var topping in characterUI[UIManager.Instance.CharacterType].ImageButtonTopping)
        {
            GameObject toppingSpawn = Instantiate(topping, Content);
            toppingSpawn.transform.SetParent(Content);
        }
        Instantiate(ModalDefult);
    }
    public void BackToStartGame()
    {
        foreach (Transform child in Content.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        DestroyGamer.destroynow=true; 
        MainGame.SetActive(false);
        UIManager.Instance.OnUiOffmainGame();
    }
}