using UnityEngine;
using System.Collections;

public class FolderButton : MonoBehaviour
{

    public string action;
    private int curid;
    private static GameObject[] card = new GameObject[5];
    public GameObject card_base;
    public GameObject home, lead, tour, shop, loot;
    private static byte cur = 1;

    void GetClose()
    {
        switch (cur)
        {
            case 1:
                CloseHome();
                break;
            case 2:
                CloseLead();
                break;
            case 3:
                CloseTour();
                break;
            case 4:
                CloseShop();
                break;
            case 5:
                CloseLoot();
                break;
        }
    }



    public void OpenHome( int id )
    {
        home.SetActive(true);
        curid = id;
        for (int i = 0; i < 5; i++)
        {
            card[i] = Instantiate(card_base) as GameObject;
            card[i].name = "Card" + (i + 1);
            card[i].transform.position = new Vector3((i - 2) * 3.7f, -1.8f - Mathf.Abs(i - 2) * Mathf.Abs(i - 2) * 0.25f, 50);
        }
    }
    void CloseHome()
    {
        home.SetActive(false);
        for (int i = 0; i < 5; i++)
            DestroyObject(card[i]);
    }



    public void OpenLead()
    {
        lead.SetActive(true);
    }
    void CloseLead()
    {
        lead.SetActive(false);
    }



    public void OpenTour()
    {
        tour.SetActive(true);
    }
    void CloseTour()
    {
        tour.SetActive(false);
    }



    public void OpenShop()
    {
        shop.SetActive(true);
    }
    void CloseShop()
    {
        shop.SetActive(false);
    }



    public void OpenLoot()
    {
        loot.SetActive(true);
    }
    void CloseLoot()
    {
        loot.SetActive(false);
    }



    void OnMouseUpAsButton()
    {
        switch (action)
        {
            case "Home":
                if (cur != 1)
                {
                    GetClose();
                    cur = 1;
                    OpenHome(1);
                }
                break;
            case "Lead":
                if (cur != 2)
                {
                    GetClose();
                    cur = 2;
                    OpenLead();
                }
                break;
            case "Tour":
                if (cur != 3)
                {
                    GetClose();
                    cur = 3;
                    OpenTour();
                }
                break;
            case "Shop":
                if (cur != 4)
                {
                    GetClose();
                    cur = 4;
                    OpenShop();
                }
                break;
            case "Loot":
                if (cur != 5)
                {
                    GetClose();
                    cur = 5;
                    OpenLoot();
                }
                break;
        }
    }
}
