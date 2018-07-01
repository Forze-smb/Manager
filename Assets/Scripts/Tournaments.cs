using UnityEngine;
using System.Collections;

public class Tournaments : MonoBehaviour {

    public string nametour = "Major", country = "Arctic";
    public int fond = 1000000, places = 8, ill = 1; // 8 teams 1ill = 1 - 40%  2 - 20%  3-4 - 10%  5-8 - 5%
    public int[] teams = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
    private float[] pct = new float[8] { 0.4f, 0.2f, 0.1f, 0.1f, 0.05f, 0.05f, 0.05f, 0.05f };
    public int[] place = new int[8];
    public int[] groupA = new int[4], groupB = new int[4];
    public int[] bo = new int[3] { 3, 3, 5 };
}
