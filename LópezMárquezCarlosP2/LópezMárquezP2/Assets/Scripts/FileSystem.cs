using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UIElements;
using System.Runtime.Serialization.Formatters.Binary;


public class FileSystem : MonoBehaviour
{
    public static FileSystem instance;
    public GameObject obj;
    public bool isSavingPosition = false;
    public GameObject obj2;
    public PlayerData p;

    private void Awake()
    {
        if (instance! == null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }
    void CreateFile(string _fileName, string _extension, string _data)
    {
        //1) Acceder al path del archivo
        string fileName = "Nombre";
        string extension = ".txt"
;       string path = Application.dataPath + "/Resources/" + fileName + extension;
        //2) Crear el archivo si no existe otro con el mismo nombre
        if (!File.Exists(path))
        {
            //3) Escribir dentro del archivo
            File.WriteAllText(path, "Hola");
        }
        //4) Almacenar dentro del archivo
            string data = "Login Date: " + System.DateTime.Now + "\n";
        //5) Agregar dentro del archivo
        File.AppendAllText(path, _data);
    }
    void SaveObjectPosition(Transform _objTransform)
    {
        string fileName = "positions";
        string extension = ".txt"
; string path = Application.dataPath + "/Resources/" + fileName + extension;
        //2) Crear el archivo si no existe otro con el mismo nombre
        if (!File.Exists(path))
        {
            //3) Escribir dentro del archivo
            File.WriteAllText(path, "Hola");
        }
        //4) Almacenar dentro del archivo
        string data = "Position: " + "(" + _objTransform.position.x.ToString() + ", "
                                         + _objTransform.position.y.ToString() + ", " 
                                         + _objTransform.position.z.ToString() + ", " 
                                         + "\n";
        //5) Agregar dentro del archivo
        File.AppendAllText(path, data);
    }
    string ReadFile(string _fileName, string _extension)
    {
        string path = Application.dataPath + "/Resources/" + _fileName + _extension;
        string data = "";
        if (File.Exists(path))
        {
            data = File.ReadAllText(path);
        }
        return data;
    }

    // Update is called once per frame
    Vector3 ParseStringToVector3(string input)
    {
        Vector3 result = Vector3.zero;
        string[] components = input.Split(',');
        if (components.Length == 3)
        {
            if (float.TryParse(components[0], out float x) && float.TryParse(components[0], out float y) && float.TryParse(components[0], out float z))
            {
                result = new Vector3(x, y, z);
            }
            else
            {
                Debug.LogError("No se pudieron convertir todos los componentes a numeros.");
            }
        }
        else
        {
            Debug.LogWarning("El formato del string no es válido");
        }
        return result;
    }
    public void SaveToJSON(string _fileName, object _data)
    {
        string JSONData = JsonUtility.ToJson(_data);
        if (JSONData.Length != 0)
        {
            Debug.Log("JSON STRING: " + JSONData);
            CreateFile(_fileName, ".json", JSONData);
        }
        else
        {
            Debug.LogWarning("File System: string JSONData is empty, please check saved object");
        }
    }
    public T LoadFromJSON<T>(string _fileName) where T : new()
    {
        T data = new T();
        string JSONData = ReadFile(_fileName, ".json");
        if (JSONData.Length != 0)
        {
            Debug.Log("DATA FROM FILE: " + JSONData);
            JsonUtility.FromJsonOverwrite(JSONData, data);
        }
        else
        {
            Debug.LogWarning("File System: string JSONData is empty, pleae check saved object");
        }
        return data;
    }
    public void SaveToBinary(string _fileName, object _data)
    {
        BinaryFormatter bf = new BinaryFormatter();
        string path = Application.dataPath + "/Resources/" + _fileName + ".file";
        FileStream stream = new FileStream(path, FileMode.Create);
        bf.Serialize(stream, _data);
        stream.Close();
    }
    void Start()
    {
        SaveToBinary("Carlos", p);
        p = LoadFromJSON<PlayerData>("Carlos");

        SaveObjectPosition(obj.transform);
        string data = ReadFile("example", "_txt");
        Debug.Log("Informaci+on del archivo: \n" + data);
        obj2.transform.position = ParseStringToVector3(data);
    }
    void Update()
    {
        if (isSavingPosition)
        {
            SaveObjectPosition(obj.transform);
        }
    }
}
