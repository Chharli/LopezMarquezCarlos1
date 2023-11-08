using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public List<Character> characters;
    public Character CharData;
    public GameObject dummy;
    public void LoadCharacters(string _fileName)
    {
        string path = Application.dataPath + "/Resources/" + _fileName + ".json";
        string data = File.ReadAllText(path);
        var resource = JSON.Parse(data);

        for (int i = 0; i < resource.Count; i++)
        {
            Character character = new Character();
            character.name = resource[i]["name"].Value;
            character.rarity = resource[i]["rarity"].Value;
            character.id = int.Parse(resource[i]["id"].Value);
            characters.Add(character);
        }
        void Start()
        {
            characters = new List<Character>();
            LoadCharacters("characters");
        }
    }
}
