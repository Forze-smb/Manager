using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Team : MonoBehaviour {

    public string namet;
    public int funs, goldtick, skill, social, med, team_mmr, teamplay, lang, gold_in, sponsor, tacticals;
    public int[] team_info = new int[7]; // 0 - media 1-5 - player pos 6 - coach

    void Start()
    {

    }

    void UpdateInfo()
    {
        funs = 0;
        for (int i = 1; i <= 5; i++)
            funs += GameObject.Find("Player" + team_info[i]).GetComponent<Player>().funs;
        funs += GameObject.Find("Player" + team_info[0]).GetComponent<Player>().funs * 2;
        funs += GameObject.Find("Player" + team_info[6]).GetComponent<Player>().funs / 2;
    }
}
