using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[System.Serializable]

public struct CRData
{
    public int Level;
    public int Gold;
    public int Emeralds;
    public string User;
    public string Clan;
}

public class MainMenuData : MonoBehaviour
{
    [Header("Main Menu Config")]
    public CRData data;
    [Header("Main Menu UI")]

    public TMP_Text Level;
    public TMP_Text Gold;
    public TMP_Text Emeralds;
    public TMP_Text User;
    public TMP_Text Clan;

    // Start is called before the first frame update
    void Start()
    {
        Level.text = data.Level.ToString() + "/100";
        Gold.text = data.Gold.ToString();
        Emeralds.text = data.Emeralds.ToString();
        User.text = data.User.ToString();
        Clan.text = data.Clan.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Level.text = data.Level.ToString() + "/100";
        Gold.text = data.Gold.ToString();
        Emeralds.text = data.Emeralds.ToString();
        User.text = data.User.ToString();
        Clan.text = data.Clan.ToString();
    }
}
