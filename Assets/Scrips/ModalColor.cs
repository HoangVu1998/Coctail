using UnityEngine;
using UnityEngine.UI;

public class ModalColor : MonoBehaviour
{
    //private Renderer objectRenderer;
    SpriteRenderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetColorToYellow()
    {
        objectRenderer.color = Color.yellow;
    }

    public void SetColorToBlue()
    {
        objectRenderer.color = Color.blue;
    }

    public void SetColorToRed()
    {
        objectRenderer.color = Color.red;
        Debug.Log("colorisRed");
    }
}
