using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeLine : MonoBehaviour
{
    public GameObject base_;
    public Transform find;
    public string text;
    private int count = 0, id;
    void Update()
    {
        id = System.Int32.Parse(base_.name.Substring(4));
        switch (text)
        {
            case "skill":
                count = GameObject.Find("Player" + id).GetComponent<Player>().skill;
                break;
            case "media":
                count = GameObject.Find("Player" + id).GetComponent<Player>().med;
                break;
            case "social":
                count = GameObject.Find("Player" + id).GetComponent<Player>().social;
                break;
        }
        for (int i = 1; i <= count; i++)
            find.transform.Find(text + i).gameObject.SetActive(true);
        for (int i = count + 1; i <= 10; i++)
            find.transform.Find(text + i).gameObject.SetActive(false);
    }
}
