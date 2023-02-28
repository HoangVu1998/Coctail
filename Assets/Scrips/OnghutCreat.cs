using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnghutCreat : MonoBehaviour
{
    public GameObject[] objectsToShow; // Mảng chứa tất cả các đối tượng cần hiển thị
    private GameObject currentlyShownObject; // Biến lưu trữ đối tượng hiện đang được hiển thị

    public void ShowObject(int index)
    {
        if (currentlyShownObject != null)
        { // Kiểm tra xem có đối tượng đang hiển thị hay không
            if (currentlyShownObject.activeSelf && currentlyShownObject == objectsToShow[index])
            {
                // Nếu đối tượng đã được chọn trước đó đang hiển thị, ta sẽ tắt nó đi
                Destroy(currentlyShownObject);
                currentlyShownObject = null;
                return;
            }
            Destroy(currentlyShownObject); ; // Nếu không, tắt đối tượng đó đi
        }

        currentlyShownObject = Instantiate(objectsToShow[index]); // Lưu trữ đối tượng mới đang được chọn
        currentlyShownObject.SetActive(true); // Hiển thị đối tượng mới đó lên
    }
}
