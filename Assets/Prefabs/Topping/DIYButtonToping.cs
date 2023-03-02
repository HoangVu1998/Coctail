using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;

public class DIYButtonToping : ToppingButton
{
    FuritsManager furitsManager;
    public DIYMain DYYMain;
    public static DIYButtonToping instace;

    private void Awake()
    {
        instace= this;  
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
    {
        // Lấy ra một vị trí ngẫu nhiên trong khoảng giữa hai điểm PointThrowFruits
        var position = new Vector2(UnityEngine.Random.Range(furitsManager.FutirsPointThrow[0].position.x, furitsManager.FutirsPointThrow[1].position.x), furitsManager.FutirsPointThrow[0].position.y);
        // Tạo ra một đối tượng mới từ mảng FruitsPrefabsBeer ở vị trí position
        var a = Instantiate(furitsManager.characterUIList[UIManager.Instance.CharacterType].FrutisList[Index], position, Quaternion.identity);
        DYYMain.CountFurits++;
        
        Save(Index);
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
        Debug.Log(index);
    }
    public void Save(int index)
    {
        // Lấy số lần được nhấn của nút bấm hiện tại
        int currentCount = PlayerPrefs.GetInt("button_" + index.ToString(), 0);

        // Tăng giá trị số lần đó lên 1 và lưu vào key tương ứng
        currentCount++;
        PlayerPrefs.SetInt("button_" + index.ToString(), currentCount);

        // Lưu lại để chắc chắn rằng thay đổi được lưu vào PlayerPrefs
        PlayerPrefs.Save();
    }
    public int Load(int index)
    {
        // Lấy giá trị số lần được nhấn từ key tương ứng
        int count = PlayerPrefs.GetInt("button_" + index.ToString(), 0);
        // Trả về giá trị số lần đó
        return count;
    }
    public void CreatFutits()
    {
        var position = new Vector2(UnityEngine.Random.Range(furitsManager.FutirsPointThrow[0].position.x, furitsManager.FutirsPointThrow[1].position.x), furitsManager.FutirsPointThrow[0].position.y);
        for (int i = 0; i < furitsManager.characterUIList[UIManager.Instance.CharacterType].FrutisList.Count;i++)
        {
          Debug.Log("Load(i)"  +" "+i+ " " + Load(i));
            for (int j=0;j<Load(i);j++)
            {
                Instantiate(furitsManager.characterUIList[UIManager.Instance.CharacterType].FrutisList[i], position, Quaternion.identity);
                Debug.Log("Load(i)" + i+ "  "+j);
            } 
        }
        ResetScores();
    }
    public void ResetScores()
    {
        PlayerPrefs.DeleteAll();
    }
}
