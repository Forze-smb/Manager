using UnityEngine;
using System.Collections;

public class TourButton : MonoBehaviour {

    public GameObject self;
    public static GameObject cur;

    void OnMouseUpAsButton()
    {
        if (cur != null)
            cur.SetActive(false);
        cur = self;
        cur.SetActive(true);
    }
}
