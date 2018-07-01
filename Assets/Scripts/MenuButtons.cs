using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuButtons : MonoBehaviour {

    public Sprite unpr, pr;
    public string action;

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = pr;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = unpr;
    }

    void OnMouseUpAsButton()
    {
        switch (action)
        {
            case "Start":
                Application.LoadLevel("game");
                break;
        }
    }
}
