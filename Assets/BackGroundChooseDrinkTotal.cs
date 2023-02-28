using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundChooseDrinkTotal : MonoBehaviour
{
    public GameObject mainModal;
    GameObject childObject;
    SpriteRenderer spriteRenderer;
    public Sprite[] modalBeerSprites;
    public GameObject MainGame;
    GameObject currentMainModal;
    private void Awake()
    {
        Transform childTransform = mainModal.transform.GetChild(0).Find("Modal"); // Tìm đối tượng con có tên là ChildObject
        childObject = childTransform.gameObject; // Lấy đối tượng con dưới dạng GameObject
        spriteRenderer = childTransform.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (LevelController.isShake == true)
        {
            var a = Instantiate(mainModal);
            LevelController.isShake = false;
            if (DetectShake.uonghet == true)
            {
                Destroy(a);
            }
        }
    }
    public void onclickBeer()
    {
        spriteRenderer.sprite = modalBeerSprites[CardDisplay.CurentIndexer];
        mainModal.SetActive(true);
        Instantiate(mainModal);
        gameObject.SetActive(false);
        MainGame.SetActive(true);
    }
}
