using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CharacterUI1", menuName = "CharacterUI")]
public class NewBehaviourScript : ScriptableObject
{
    [SerializeField]
    public List<Sprite> CharacterUI1 = new List<Sprite>();
    [SerializeField]
    public List<Sprite> CharacterModal1 = new List<Sprite>();
}
