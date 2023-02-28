using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCOntroller : MonoBehaviour
{
    public GameObject[] BobaTea;
    public GameObject[] mocktail;
    public float CurrentIndex = 0;
    public void LoadLevel(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void Toright()
    {
        
    }
}
