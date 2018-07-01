using UnityEngine;
using System.Collections;

public class GameEngine : MonoBehaviour {
    const int count = 40 + 1, tcount = 8 + 1;
    private DataBase data = new DataBase();
    public GameObject orig_player, orig_team;
    private GameObject[] player = new GameObject[count];
    private GameObject[] team = new GameObject[tcount];
    private FolderButton menu;
    public int cur_button = 1;


    void Start () {
        menu = GameObject.Find("Background").GetComponent<FolderButton>();
        for (int i = 0; i < count; i++)
        {
            player[i] = Instantiate(orig_player) as GameObject;
            player[i].name = "Player" + i;
            player[i].GetComponent<Player>().nick = data.d_nick[i];
            for (int j = 0; j < 15; j++)
                player[i].GetComponent<Player>().lang[j] = data.d_lang[i,j];
            player[i].GetComponent<Player>().age = data.d_age[i];
            player[i].GetComponent<Player>().cost = data.d_cost[i];
            player[i].GetComponent<Player>().funs = data.d_funs[i];
            player[i].GetComponent<Player>().skill = data.d_skill[i];
            player[i].GetComponent<Player>().social = data.d_social[i];
            player[i].GetComponent<Player>().med = data.d_med[i];
            player[i].GetComponent<Player>().pos = data.d_pos[i];
            player[i].GetComponent<Player>().solo_mmr = data.d_solo_mmr[i];
            player[i].GetComponent<Player>().team = data.d_team[i];
        }
        for (int i = 0; i < tcount; i++)
        {
            team[i] = Instantiate(orig_team) as GameObject;
            team[i].name = "Team" + i;
            team[i].GetComponent<Team>().namet = data.t_namet[i];
        }
        menu.OpenHome(1);
    }
	
	void Update () {
	    
	}
}
