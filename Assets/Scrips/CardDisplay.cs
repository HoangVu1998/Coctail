using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CardDisplay : MonoBehaviour
{
    public CardDefuld card;
    public Image modalDrink;
    public Image tikket;
    public Button buttonModalDrink;
    public static int CurentIndexer = 0;
    private void Start()
    {
        modalDrink.sprite = card.listCard[CurentIndexer].ModalDrink;
        tikket.sprite = card.listCard[CurentIndexer].Tikket;
    }
    public void ToRight()
    {
        if (CurentIndexer < card.listCard.Count - 1)
        {
            CurentIndexer++;
        }
        else
        {
            CurentIndexer = 0;
        }
        showCard();
    }
    public void ToLeft()
    {
        if (CurentIndexer > 0)
        {
            CurentIndexer--;
        }
        else
        {
            CurentIndexer = card.listCard.Count - 1;
        }
        showCard();
    }
    public void showCard()
    {
        modalDrink.sprite = card.listCard[CurentIndexer].ModalDrink;
        tikket.sprite = card.listCard[CurentIndexer].Tikket;

    }
}
