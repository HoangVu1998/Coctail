using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsController : MonoBehaviour
{
    // qu?n lý các ??i t??ng hoa qu?
    public GameObject[] fruitsPrefabsBeer;


    // M?ng v? trí r?i c?a ??i t??ng hoa qu?
    public Transform[] PointThrowFruits;
    public void ChooseFurits(int number)
    {
        var position =new Vector2(Random.Range(PointThrowFruits[0].position.x,PointThrowFruits[1].position.x), PointThrowFruits[0].position.y);
        var a = Instantiate(fruitsPrefabsBeer[number],position,Quaternion.identity);
        if (DetectShake.uonghet == true)
        {
            Destroy(a);
        }
    }
}
