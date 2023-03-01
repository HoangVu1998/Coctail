﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DIYButtonToping : ToppingButton
{
    FuritsManager furitsManager;
    public DIYMain DYYMain;
    // Start is called before the first frame update
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
    public override void chooseToppingBeer(int Index)
    {// Lấy ra một vị trí ngẫu nhiên trong khoảng giữa hai điểm PointThrowFruits
        var position = new Vector2(Random.Range(furitsManager.FutirsPointThrow[0].position.x, furitsManager.FutirsPointThrow[1].position.x), furitsManager.FutirsPointThrow[0].position.y);
        // Tạo ra một đối tượng mới từ mảng FruitsPrefabsBeer ở vị trí position
        var a = Instantiate(furitsManager.characterUIList[UIManager.Instance.CharacterType].FrutisList[Index], position, Quaternion.identity);
        DYYMain.CountFurits++;

        a.transform.SetParent(DYYMain.ModalClone.transform);

        // Kiểm tra nếu biến uonghet được set là true từ DetectShake, hủy đối tượng
        if (DetectShake.uonghet == true)
        {
            Destroy(a);
        }
    }
    public void onClickModalDIY()
    {
        GameObject clickedModalClone = EventSystem.current.currentSelectedGameObject;
        int index = DYYMain.modalCloneList.IndexOf(clickedModalClone);
        DYYMain.Indexer = index;
        Debug.Log(DYYMain.Indexer);
    }
}