using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoneyEngine : MonoBehaviour {
    
    public GameObject money_text;
    public static int money = 0;

	void Update ()
    {
        money_text.GetComponent<Text>().text = "$" + money;
    }

    public static bool PayMoney( int pay )
    {
        if (money > pay)
        {
            money -= pay;
            return true;
        }
        return false;
    }
}
