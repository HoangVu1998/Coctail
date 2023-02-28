using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    [SerializeField]
    private GameObject Loading_Bar_Holder;
    [SerializeField] private Image Loading_Bar_Progess;
    public float progress_Value = 0.1f;
    public float Progress_Multiple_1 = 0.1f;
    public float Level_Time = 3f;
    void Start()
    {
        StartCoroutine(LoadingSomeLevel());
    }
    void Update()
    {
        ShowLoadingScreen();
    }
    public void LoadLevel(string Levelname)
    {
        Loading_Bar_Holder.SetActive(true);
        progress_Value = 0;
        SceneManager.LoadScene(Levelname);
    }
    void ShowLoadingScreen()
    {
        if (progress_Value < 1)
        {
            progress_Value += Progress_Multiple_1 * Time.deltaTime;
            Loading_Bar_Progess.fillAmount = progress_Value;
            if (progress_Value >= 1)
            {
                progress_Value = 1.1f;
                Loading_Bar_Progess.fillAmount = 0;
                Loading_Bar_Holder.SetActive(false);

            }
        }
    }
    IEnumerator LoadingSomeLevel()
    {
        yield return new WaitForSeconds(Level_Time);
       // LoadLevel("Start");
        loadLevelAsync("Start");

    }
    public void loadLevelAsync(string Levelname)
    {
        StartCoroutine(LoadAsynchronously(Levelname));
    }
    IEnumerator LoadAsynchronously(string levelName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelName);
        Loading_Bar_Holder.SetActive(true);
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            Loading_Bar_Progess.fillAmount = progress;
            if (progress >= 1)
            {
                Loading_Bar_Holder.SetActive(false);
            }
            yield return null;
        }
    }
}
