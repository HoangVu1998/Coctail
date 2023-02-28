using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class ToppingButton : MonoBehaviour
{
    FuritsManager furitsManager;
    public DIYMain DYYMain;
    private void Awake()
    {
        // Tìm đối tượng FuritsController trên cảnh
        GameObject GameOBJ = GameObject.Find("FuritsManager");
        // Lấy thành phần "FuritsManager" từ đối tượng
        furitsManager = GameOBJ.GetComponent<FuritsManager>();
        // Tìm đối tượng DIY trên cảnh
        GameObject GameOB = GameObject.Find("DIY");
        // Lấy thành phần "DYYMain" từ đối tượng
        DYYMain = GameOB.GetComponent<DIYMain>();
    }
    public void chooseToppingBeer(int Index)
    {
        // Lấy ra một vị trí ngẫu nhiên trong khoảng giữa hai điểm PointThrowFruits
        var position = new Vector2(Random.Range(furitsManager.FutirsPointThrow[0].position.x, furitsManager.FutirsPointThrow[1].position.x), furitsManager.FutirsPointThrow[0].position.y);

        // Tạo ra một đối tượng mới từ mảng FruitsPrefabsBeer ở vị trí position
        var a = Instantiate(furitsManager.characterUIList[UIManager.Instance.CharacterType].FrutisList[Index], position, Quaternion.identity);

        // Kiểm tra nếu biến uonghet được set là true từ DetectShake, hủy đối tượng
        if (DetectShake.uonghet == true)
        {
            Destroy(a);
        }
    }
    public void onClickModalDIY()
    {
        //TỌA RA BẢN SAO ĐỐI TƯỢNG TRÊN MÀN 1
        GameObject clickedModalClone = EventSystem.current.currentSelectedGameObject;
        int index = DYYMain.modalCloneList.IndexOf(clickedModalClone);
        DYYMain.Indexer=index;  
       // GameObject newModalClone = Instantiate(DYYMain.modalCloneList[index], transform.parent);
       // newModalClone.transform.SetParent(DYYMain.Panel1);
       // DYYMain.NewmodalCloneList.Add(clickedModalClone);
       //ĐI TỚI MÀN 2
    }
}
