using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatGameACtive : MonoBehaviour
{
    public GameObject StartGame;
    void Start()
    {
        StartCoroutine(SetActiveStartGame1());
    }

    public void SetActiveStartGame(GameObject Startgame)
    {
        Startgame.SetActive(true);
        gameObject.SetActive(false);    
    }
    IEnumerator SetActiveStartGame1()
    {
        yield return new WaitForSeconds(1f);
        SetActiveStartGame(StartGame);
    }
}
