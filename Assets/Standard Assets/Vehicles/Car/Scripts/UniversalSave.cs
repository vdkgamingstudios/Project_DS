using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    [Header("Saving Variables")]
    public static int LapCounts;
    public static int OpponentsCount;

    [Header("Player Stats")]
    public static int CreditAmount;
    public static bool Saving = false;
    public static string PlayerName = "PLAYER";
    public static int RacesWon = 0;
    public static int RacesLost = 0;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        LoadStats();
    }

    private void Update()
    {
        if(Saving == true)
        {
            Saving = false;
            SaveStats();
        }
    }

    public void SaveStats()
    {
        PlayerPrefs.SetInt("MyCredits", CreditAmount);
        PlayerPrefs.SetString("NamePlayer", PlayerName);
        PlayerPrefs.SetInt("WonRaces", RacesWon);
        PlayerPrefs.SetInt("LostRaces", RacesLost);
    }

    public void LoadStats() 
    {
        CreditAmount = PlayerPrefs.GetInt("MyCredits");
        PlayerName = PlayerPrefs.GetString("NamePlayer");
        RacesWon = PlayerPrefs.GetInt("WonRaces");
        RacesLost = PlayerPrefs.GetInt("LostRaces");
    }
}
