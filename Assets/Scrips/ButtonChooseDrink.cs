using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChooseDrink : MonoBehaviour
{
    public GameObject[] objectsToShow; // Mảng chứa tất cả các đối tượng cần hiển thị
    private GameObject currentlyShownObject; // Biến lưu trữ đối tượng hiện đang được hiển thị
    private void Start()
    {
        currentlyShownObject = objectsToShow[0];
    }

    public void ShowObject(int index)
    {
        if(currentlyShownObject != objectsToShow[index])
        {
            currentlyShownObject.SetActive(false);
            currentlyShownObject = objectsToShow[index];
            currentlyShownObject.SetActive(true);
        }
        else
        {
            return;
        }
    }
}
