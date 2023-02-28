using UnityEngine;
using UnityEngine.UI;

public class BgShow : MonoBehaviour
{
    //public GameObject[] objectsToShow; // Mảng chứa tất cả các đối tượng cần hiển thị
    //private GameObject currentlyShownObject; // Biến lưu trữ đối tượng hiện đang được hiển thị

    //public void ShowObject(int index)
    //{
    //    Debug.Log("Showobject_" + index);
    //    if (currentlyShownObject != null)
    //    { // Kiểm tra xem có đối tượng đang hiển thị hay không
    //        if (currentlyShownObject.activeSelf && currentlyShownObject == objectsToShow[index])
    //        {
    //            // Nếu đối tượng đã được chọn trước đó đang hiển thị, ta sẽ tắt nó đi
    //            currentlyShownObject.SetActive(false);
    //            currentlyShownObject = null;
    //            return;
    //        }
    //        currentlyShownObject.SetActive(false); // Nếu không, tắt đối tượng đó đi
    //    }
    //    currentlyShownObject = objectsToShow[index]; // Lưu trữ đối tượng mới đang được chọn
    //    currentlyShownObject.SetActive(true); // Hiển thị đối tượng mới đó lên
    //    Debug.Log("22222Showobject_" + index);
    //}
    public GameObject[] objectsToShow; // Mảng chứa tất cả các đối tượng cần hiển thị
    private GameObject currentlyShownObject; // Biến lưu trữ đối tượng hiện đang được hiển thị
    public void ShowObject(int index)
    {
        if (currentlyShownObject != null)
        { // Kiểm tra xem có đối tượng đang hiển thị hay không
            if (currentlyShownObject.activeSelf && currentlyShownObject == objectsToShow[index])
            {
                // Nếu đối tượng đã được chọn trước đó đang hiển thị, ta sẽ tắt nó đi
                Debug.Log("Showobject_" + index);
                Destroy(currentlyShownObject);
                currentlyShownObject = null;
                return;
            }
            Destroy(currentlyShownObject); ; // Nếu không, tắt đối tượng đó đi
        }
        currentlyShownObject = Instantiate(objectsToShow[index]); // Lưu trữ đối tượng mới đang được chọn
        currentlyShownObject.SetActive(true);
    }
    public void DestroyBackGround()
    {
        Destroy(currentlyShownObject);
    }
}

