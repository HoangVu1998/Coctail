using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManagerModalDrink : MonoBehaviour
{
    public Sprite[] DrinkBeer;
    public Sprite[] DrinkCoktail;
    public Sprite[] More;

    public GameObject modalDefault;
    
    protected SpriteRenderer spriteRendererMain;
   


    //quản lý card chung: beer, coctail, more.
    public CardDefuld cardBeer;
    public CardDefuld cardCoctail;
    public CardDefuld cardMore;

    // vị trí sinh ra các nút button
    public Transform content;

    //Các Scene của game
    public GameObject MainGame;
    public GameObject StartGame;
    public GameObject DIY;
    // hiệu ứng lắc để reset màn chơi.
    public GameObject Lac;

    // public GameObject[] ScrollFurits;
    private void Awake()
    {
        // Tìm đối tượng con có tên là Modal
        Transform childTransformMain = modalDefault.transform.GetChild(0).Find("Modal");
        
        // thay sprite của đối tượng modalDufalt của modal nguyên thủy
        spriteRendererMain = childTransformMain.GetComponent<SpriteRenderer>();
        

    }
    private void Update()
    {
        if (LevelController.isShake == true)
        {
            var a = Instantiate(modalDefault);
            LevelController.isShake = false;
            if (DetectShake.uonghet == true)
            {
                Destroy(a);
            }
        }
    }
    // quản lý beer
    public virtual void onclickBeer()
    {
        StartGame.SetActive(false);
        MainGame.SetActive(true);
        spriteRendererMain.sprite = DrinkBeer[CardDisplay.CurentIndexer];
        // tạo ra các button bấm chọn topping beer - nằm dưới content
        foreach (var topping in cardBeer.listCard[0].ToppingBeer.ListTopping)
        {
            GameObject toppingSpawn = Instantiate(topping, content);
            toppingSpawn.transform.SetParent(content);
        }
        modalDefault.SetActive(true);
        Instantiate(modalDefault);
    }
    public void onclickDIYBeer(int numberImage)
    {
        DIY.SetActive(false);
        StartGame.SetActive(false);
        MainGame.SetActive(true);
        spriteRendererMain.sprite = DrinkBeer[numberImage];
        // tạo ra các button bấm chọn topping beer - nằm dưới content
        foreach (var topping in cardBeer.listCard[0].ToppingBeer.ListTopping)
        {
            GameObject toppingSpawn = Instantiate(topping, content);
            toppingSpawn.transform.SetParent(content);
        }
        modalDefault.SetActive(true);
        Instantiate(modalDefault);
    }
    // quản lý coktail
    public void onclickCoktail()
    {
        StartGame.SetActive(false);
        MainGame.SetActive(true);
        spriteRendererMain.sprite = DrinkCoktail[CardDisplay.CurentIndexer];
        // tạo ra các button bấm chọn topping coctail - nằm dưới content
        foreach (var topping in cardCoctail.listCard[1].ToppingBeer.ListTopping)
        {
            GameObject toppingSpawn = Instantiate(topping, content);
            toppingSpawn.transform.SetParent(content);
        }
        modalDefault.SetActive(true);
        Instantiate(modalDefault);
    }
    public void onclickDIYCoktail(int numberImage)
    {
        DIY.SetActive(false);
        StartGame.SetActive(false);
        MainGame.SetActive(true);
        spriteRendererMain.sprite = DrinkCoktail[numberImage];
        // tạo ra các button bấm chọn topping coctail - nằm dưới content
        foreach (var topping in cardCoctail.listCard[0].ToppingBeer.ListTopping)
        {
            GameObject toppingSpawn = Instantiate(topping, content);
            toppingSpawn.transform.SetParent(content);
        }
        modalDefault.SetActive(true);
        Instantiate(modalDefault);
    }

    //quản lý more
    public void onclickMore()
    {
        StartGame.SetActive(false);
        MainGame.SetActive(true);
        spriteRendererMain.sprite = More[CardDisplay.CurentIndexer];
        // tạo ra các button bấm chọn topping coctail - nằm dưới content
        foreach (var topping in cardCoctail.listCard[0].ToppingMore.ListTopping)
        {
            GameObject toppingSpawn = Instantiate(topping, content);
            toppingSpawn.transform.SetParent(content);
        }
        modalDefault.SetActive(true);
        Instantiate(modalDefault);
    }
    public void onclickDiyMore(int numberImage)
    {
        DIY.SetActive(false);
        StartGame.SetActive(false);
        MainGame.SetActive(true);
        spriteRendererMain.sprite = More[numberImage];
        // tạo ra các button bấm chọn topping coctail - nằm dưới content
        foreach (var topping in cardCoctail.listCard[2].ToppingMore.ListTopping)
        {
            GameObject toppingSpawn = Instantiate(topping, content);
            toppingSpawn.transform.SetParent(content);
        }
        modalDefault.SetActive(true);
        Instantiate(modalDefault);
    }
    // quản lý button BACK
    public void DestroyGameDefult()
    {
        DestroyGamer.destroynow = true;
        foreach (Transform child in content.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        DetectShake.uonghet = false;
        Lac.SetActive(false);
        StartGame.SetActive(true);
        MainGame.SetActive(false);
    }
}
