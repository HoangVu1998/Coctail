using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ToppingBeer", menuName = "Toppping")]
public class ScriptableTopping : ScriptableObject
{
    public List<GameObject> ListTopping = new List<GameObject>();
}
