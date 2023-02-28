using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUIManager : MonoBehaviour
{
    public static CharacterUIManager instance;
    public int CharacterType;
    public List<characterUI> ListCharacterUI = new List<characterUI>();
    public int IndexerImageCharacter;

    public Image ImageCharacter;
    private void Awake()
    {
        instance = this;
        CharacterType = 0;
        IndexerImageCharacter = 0;
        ImageCharacter = GetComponent<Image>();

    }
    void Start()
    {
        ShowCharacterImage();
    }
    public void OnclickChooseCharacterType(int characterType)
    {
        if (characterType == 0)
        {
            this.CharacterType = 0;
        }
        if (characterType == 1)
        {
            this.CharacterType = 1;
        }
        if (characterType == 2)
        {
            this.CharacterType = 2;
        }
        IndexerImageCharacter = 0;
        ShowCharacterImage();
        UIManager.Instance.CharacterType = CharacterType;

    }
    public void ToRight()
    {
        IndexerImageCharacter++;
        if (IndexerImageCharacter > ListCharacterUI[CharacterType].CharacterUI.Count - 1)
        {
            IndexerImageCharacter = 0;
        }
        ShowCharacterImage();
    }
    public void ToLeft()
    {
        IndexerImageCharacter--;
        if (IndexerImageCharacter < 0)
        {
            IndexerImageCharacter = ListCharacterUI[CharacterType].CharacterUI.Count - 1;
        }
        ShowCharacterImage();
    }
    public void ShowCharacterImage()
    {
        ImageCharacter.sprite = ListCharacterUI[CharacterType].CharacterUI[IndexerImageCharacter];
    }
    public void onClickCharacter()
    {
        UIManager.Instance.CharacterType = CharacterType;
        UIManager.Instance.IndexerCharacterType= IndexerImageCharacter;
    }
}
