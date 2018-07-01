using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoneyCount : MonoBehaviour {
    
	void Update ()
    {
        GetComponent<Text>().text = GameObject.Find("Player" + id).GetComponent<Player>().nick;
    }
}
