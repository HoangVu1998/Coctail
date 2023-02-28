using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Card/minion")]
public class CardDefuld : ScriptableObject
{
    public List<Card> listCard = new List<Card>();

}
[System.Serializable]
public class Card
{
    public Sprite ModalDrink;
    public Sprite Tikket;
    public ScriptableTopping ToppingBeer;
    public ScriptableTopping ToppingCoctail;
    public ScriptableTopping ToppingMore;
}
