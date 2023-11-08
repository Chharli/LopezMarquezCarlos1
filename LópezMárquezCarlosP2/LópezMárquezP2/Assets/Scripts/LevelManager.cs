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
    public GameObject chara, chara2, chara3, chara4, chara5, chara6, chara7, chara8, chara9, chara10,
        chara11, chara12, chara13, chara14, chara15, chara16, chara17, chara18, chara19, chara20, chara21, chara22,
        chara23, chara24, chara25, chara26, chara27, chara28, chara29, chara30, chara31, chara32, chara33, chara34,
        chara35, chara36, chara37, chara38, chara39, chara40, chara41, chara42, chara43, chara44, chara45, chara46,
        chara47, chara48, chara49, chara50, chara51, chara52, chara53, chara54;
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

            chara.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[0].name;
            chara.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[0].id.ToString();
            chara2.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[1].name;
            chara2.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[1].id.ToString();
            chara3.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[2].name;
            chara3.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[2].id.ToString();
            chara4.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[3].name;
            chara4.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[3].id.ToString();
            chara5.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[4].name;
            chara5.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[4].id.ToString();
            chara6.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[5].name;
            chara6.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[5].id.ToString();
            chara7.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[6].name;
            chara7.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[6].id.ToString();
            chara8.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[7].name;
            chara8.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[7].id.ToString();
            chara9.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[8].name;
            chara9.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[8].id.ToString();
            chara10.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[9].name;
            chara10.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[9].id.ToString();
            chara11.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[10].name;
            chara11.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[10].id.ToString();
            chara12.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[11].name;
            chara12.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[11].id.ToString();
            chara13.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[12].name;
            chara13.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[12].id.ToString();
            chara14.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[13].name;
            chara14.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[13].id.ToString();
            chara15.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[14].name;
            chara15.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[14].id.ToString();
            chara16.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[15].name;
            chara16.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[15].id.ToString();
            chara17.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[16].name;
            chara17.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[16].id.ToString();
            chara18.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[17].name;
            chara18.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[17].id.ToString();
            chara19.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[18].name;
            chara19.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[18].id.ToString();
            chara20.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[19].name;
            chara20.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[19].id.ToString();
            chara21.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[20].name;
            chara21.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[20].id.ToString();
            chara22.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[21].name;
            chara22.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[21].id.ToString();
            chara23.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[22].name;
            chara23.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[22].id.ToString();
            chara24.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[23].name;
            chara24.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[23].id.ToString();
            chara25.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[24].name;
            chara25.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[24].id.ToString();
            chara26.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[25].name;
            chara26.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[25].id.ToString();
            chara27.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[26].name;
            chara27.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[26].id.ToString();
            chara28.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[27].name;
            chara28.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[27].id.ToString();
            chara29.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[28].name;
            chara29.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[28].id.ToString();
            chara30.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[29].name;
            chara30.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[29].id.ToString();
            chara31.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[30].name;
            chara31.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[30].id.ToString();
            chara32.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[31].name;
            chara32.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[31].id.ToString();
            chara33.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[32].name;
            chara33.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[32].id.ToString();
            chara34.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[33].name;
            chara34.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[33].id.ToString();
            chara35.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[34].name;
            chara35.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[34].id.ToString();
            chara36.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[35].name;
            chara36.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[35].id.ToString();
            chara37.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[36].name;
            chara37.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[36].id.ToString();
            chara38.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[37].name;
            chara38.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[37].id.ToString();
            chara39.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[38].name;
            chara39.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[38].id.ToString();
            chara40.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[39].name;
            chara40.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[39].id.ToString();
            chara41.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[40].name;
            chara41.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[40].id.ToString();
            chara42.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[41].name;
            chara42.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[41].id.ToString();
            chara43.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[42].name;
            chara43.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[42].id.ToString();
            chara44.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[43].name;
            chara44.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[43].id.ToString();
            chara45.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[44].name;
            chara45.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[44].id.ToString();
            chara46.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[45].name;
            chara46.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[45].id.ToString();
            chara47.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[46].name;
            chara47.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[46].id.ToString();
            chara48.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[47].name;
            chara48.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[47].id.ToString();
            chara49.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[48].name;
            chara49.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[48].id.ToString();
            chara50.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[49].name;
            chara50.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[49].id.ToString();
            chara51.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[50].name;
            chara51.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[50].id.ToString();
            chara52.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[51].name;
            chara52.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[51].id.ToString();
            chara53.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[52].name;
            chara53.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[52].id.ToString();
            chara54.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[53].name;
            chara54.transform.GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[53].id.ToString();
        }
    }
}
