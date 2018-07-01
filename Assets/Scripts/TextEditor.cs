using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextEditor : MonoBehaviour
{
    public GameObject base_;
    public string text, id;
    void Update()
    {
        id = base_.name.Substring(4);
        switch (text)
        {
            case "name":
                GetComponent<Text>().text = GameObject.Find("Player" + id).GetComponent<Player>().nick;
                break;
            case "age":
                GetComponent<Text>().text = GameObject.Find("Player" + id).GetComponent<Player>().age.ToString();
                break;
            case "team":
                GetComponent<Text>().text = GameObject.Find("Team" + GameObject.Find("Player" + id).GetComponent<Player>().team.ToString()).GetComponent<Team>().namet;
                break;
            case "pos":
                int pos = GameObject.Find("Player" + id).GetComponent<Player>().pos;
                string poss = "";
                if (pos % 11 == 0)
                    poss += "1";
                if (pos % 2 == 0)
                {
                    if (poss != "")
                        poss += ", ";
                    poss += "2";
                }
                if (pos % 3 == 0)
                {
                    if (poss != "")
                        poss += ", ";
                    poss += "3";
                }
                if (pos % 7 == 0)
                {
                    if (poss != "")
                        poss += ", ";
                    poss += "4";
                }
                if (pos % 5 == 0)
                {
                    if (poss != "")
                        poss += ", ";
                    poss += "5";
                }
                GetComponent<Text>().text = poss;
                break;
            case "cost":
                GetComponent<Text>().text = GameObject.Find("Player" + id).GetComponent<Player>().cost.ToString();
                break;
            case "mmr":
                GetComponent<Text>().text = GameObject.Find("Player" + id).GetComponent<Player>().solo_mmr.ToString();
                break;
        }
    }
}
