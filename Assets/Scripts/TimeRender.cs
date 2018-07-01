using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeRender : MonoBehaviour {

    public GameObject today;
    public static int day = 1, year = 0;
    
    void OnMouseUpAsButton()
    {
        day++;
        if (day > 25)
        {
            year++;
            day = 1;
        }
    }
    void Update()
    {
        today.GetComponent<Text>().text = day + " ^/ " + year;
    }
}
