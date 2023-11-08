using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class PlayerData
{
    public string Name;
    public string Description;
    public string[] Data;
    public int id;


    public PlayerData(){ }
    // Start is called before the first frame update
    public PlayerData(string _name, string _description, int _id)
    {
        Name = _name;
        Description = _description;
        id = _id;
    }
    public PlayerData(PlayerData _data)
    {

    }
    // Update is called once per frame
    public void save()
    {
        FileSystem.instance.SaveToBinary("PlayerData", this);
    }
}
