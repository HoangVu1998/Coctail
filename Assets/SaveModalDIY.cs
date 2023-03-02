using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using System;

// Khai báo lớp MyGameObjectList
[Serializable]
public class MyGameObjectList
{
    public List<GameObject> gameObjects; // Định nghĩa một List các GameObjects
}

public class GameObjectSerializer : MonoBehaviour
{
    // Đường dẫn đến file lưu trữ dữ liệu
    private string filePath = Application.persistentDataPath + "/gameObjects.dat";

    private void Start()
    {
        // Tạo một List các GameObjects và lưu nó vào file
        List<GameObject> myGameObjects = new List<GameObject>();
        myGameObjects.Add(GameObject.Find("Cube")); // Thêm GameObject "Cube" vào danh sách
        myGameObjects.Add(GameObject.Find("Sphere")); // Thêm GameObject "Sphere" vào danh sách
        Serialize(myGameObjects); // Ghi danh sách các GameObjects vào file

        // Đọc danh sách GameObject từ file và gán cho một List mới
        List<GameObject> loadedGameObjects = Deserialize();
    }

    // Serialize danh sách các GameObjects vào file
    private void Serialize(List<GameObject> gameObjects)
    {
        BinaryFormatter bf = new BinaryFormatter(); // Tạo một đối tượng BinaryFormatter để serialize dữ liệu
        FileStream file = File.Create(filePath); // Tạo một FileStream để ghi dữ liệu vào file
        bf.Serialize(file, gameObjects); // Serialize danh sách GameObject vào FileStream
        file.Close(); // Đóng FileStream
    }

    // Deserialize danh sách các GameObjects từ file
    private List<GameObject> Deserialize()
    {
        if (File.Exists(filePath)) // Kiểm tra file tồn tại
        {
            BinaryFormatter bf = new BinaryFormatter(); // Tạo một đối tượng BinaryFormatter để deserialize dữ liệu
            FileStream file = File.Open(filePath, FileMode.Open); // Tạo một FileStream để đọc dữ liệu từ file
            List<GameObject> gameObjects = (List<GameObject>)bf.Deserialize(file); // Deserialize dữ liệu từ FileStream vào danh sách GameObject
            file.Close(); // Đóng FileStream
            return gameObjects; // Trả về danh sách GameObject đã deserialize
        }
        else
        {
            Debug.LogError("File not found"); // Hiển thị lỗi nếu file không tồn tại
            return null; // Trả về null
        }
    }
}
