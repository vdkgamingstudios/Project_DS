using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIRaceTrack : MonoBehaviour
{
    //Placement in Race
    [Header("Race Track Results")]
    public TMP_Text WinMessage;
    public TMP_Text Credits;
    public GameObject Leaderboard;
    public int FirstPlaceCredits = 150;
    public int SecondPlaceCredits = 100;
    public int ThirdPlaceCredits = 50;

    // Start is called before the first frame update
    void Start()
    {
        Leaderboard.SetActive(false);

        if (UniversalSave.OpponentsCount > 0) 
        { 
            FirstPlaceCredits *= UniversalSave.OpponentsCount;
            SecondPlaceCredits *= UniversalSave.OpponentsCount;
            ThirdPlaceCredits *= UniversalSave.OpponentsCount;
        }

        if(FinishLine.PlayerFinishPosition == 1)
        {
            WinMessage.text = "1ST PLACE";
            Credits.text = FirstPlaceCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += FirstPlaceCredits;
            UniversalSave.RacesWon++;
        }
        if (FinishLine.PlayerFinishPosition == 2)
        {
            WinMessage.text = "2ND PLACE";
            Credits.text = SecondPlaceCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += SecondPlaceCredits;
            UniversalSave.RacesWon++;
        }
        if (FinishLine.PlayerFinishPosition == 3)
        {
            WinMessage.text = "3RD PLACE";
            Credits.text = ThirdPlaceCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += ThirdPlaceCredits;
            UniversalSave.RacesWon++;
        }
        if (FinishLine.PlayerFinishPosition > 3)
        {
            WinMessage.text = FinishLine.PlayerFinishPosition +"TH PLACE";
            Credits.text = "0";
            UniversalSave.RacesLost++;
        }

        UniversalSave.Saving = true;
    }

    public void DisplayLeaderboard()
    {
        Leaderboard.SetActive (true);
        this.gameObject.SetActive (false);
        Time.timeScale = 0;
    }
}
