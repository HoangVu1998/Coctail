using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CharacterUI", menuName = "CharacterUI")]
public class characterUI : ScriptableObject
{
    public List<Sprite> CharacterUI = new List<Sprite>();
    public List<Sprite> CharacterModal = new List<Sprite>();
    public List<GameObject> ImageButtonTopping = new List<GameObject>();
    public List<GameObject> DIYImageButtonTopping = new List<GameObject>();
    public List<GameObject> FrutisList = new List<GameObject>();
    public Sprite ImageTichxanh;
}