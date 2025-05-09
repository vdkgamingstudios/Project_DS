using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LeaderboardDisplay : MonoBehaviour
{
    //Variables to be used to display items on the leaderboard
    [Header("Leaderboard Display Variables")]
    public TMP_Text Position;
    public TMP_Text Name;
    public TMP_Text Minutes;
    public TMP_Text Seconds;

    public bool AI1;
    public bool AI2;
    public bool AI3;
    public bool AI4;
    public bool AI5;
    public bool AI6;
    public bool AI7;
    public bool Player;

    // Update is called once per frame
    void Update()
    {
        #region
        //AI Car One
        if (AI1 == true)
        {
            //Variables
            Position.text = FinishLineAI.AICar1FinishPosition.ToString();
            Name.text = FinishLineAI.AICar1Name;

            //Setting time variables
            if (FinishLineAI.AICar1RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar1RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar1RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar1RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar1RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar1RTSeconds).ToString();
            }
            if (FinishLineAI.AICar1RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar1RTSeconds).ToString();
            }
        }

        //AI Car Two
        if (AI2 == true)
        {
            //Variables
            Position.text = FinishLineAI.AICar2FinishPosition.ToString();
            Name.text = FinishLineAI.AICar2Name;

            //Setting time variables
            if (FinishLineAI.AICar2RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar2RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar2RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar2RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar2RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar2RTSeconds).ToString();
            }
            if (FinishLineAI.AICar2RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar2RTSeconds).ToString();
            }
        }

        //AI Car Three
        if (AI3 == true)
        {
            //Variables
            Position.text = FinishLineAI.AICar3FinishPosition.ToString();
            Name.text = FinishLineAI.AICar3Name;

            //Setting time variables
            if (FinishLineAI.AICar3RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar3RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar3RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar3RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar3RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar3RTSeconds).ToString();
            }
            if (FinishLineAI.AICar3RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar3RTSeconds).ToString();
            }
        }

        //AI Car Four
        if (AI4 == true)
        {
            //Variables
            Position.text = FinishLineAI.AICar4FinishPosition.ToString();
            Name.text = FinishLineAI.AICar4Name;

            //Setting time variables
            if (FinishLineAI.AICar4RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar4RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar4RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar4RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar4RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar4RTSeconds).ToString();
            }
            if (FinishLineAI.AICar4RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar4RTSeconds).ToString();
            }
        }

        //AI Car Five
        if (AI5 == true)
        {
            //Variables
            Position.text = FinishLineAI.AICar5FinishPosition.ToString();
            Name.text = FinishLineAI.AICar5Name;

            //Setting time variables
            if (FinishLineAI.AICar5RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar5RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar5RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar5RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar5RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar5RTSeconds).ToString();
            }
            if (FinishLineAI.AICar5RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar5RTSeconds).ToString();
            }
        }

        //AI Car Six
        if (AI6 == true)
        {
            //Variables
            Position.text = FinishLineAI.AICar6FinishPosition.ToString();
            Name.text = FinishLineAI.AICar6Name;

            //Setting time variables
            if (FinishLineAI.AICar6RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar6RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar6RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar6RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar6RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar6RTSeconds).ToString();
            }
            if (FinishLineAI.AICar6RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar6RTSeconds).ToString();
            }
        }

        //AI Car Seven
        if (AI7 == true)
        {
            //Variables
            Position.text = FinishLineAI.AICar7FinishPosition.ToString();
            Name.text = FinishLineAI.AICar7Name;

            //Setting time variables
            if (FinishLineAI.AICar7RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar7RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar7RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar7RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar7RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar7RTSeconds).ToString();
            }
            if (FinishLineAI.AICar7RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar7RTSeconds).ToString();
            }
        }

        //Player
        if (Player == true)
        {
            //Variables
            Position.text = FinishLine.PlayerFinishPosition.ToString();
            Name.text = FinishLine.PName;

            //Setting time variables
            if (SaveScript.RaceTimeMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(SaveScript.RaceTimeMinutes).ToString() + ":";
            }
            if (SaveScript.RaceTimeMinutes >= 10)
            {
                Minutes.text = Mathf.Round(SaveScript.RaceTimeMinutes).ToString() + ":";
            }
            if (SaveScript.RaceTimeSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(SaveScript.RaceTimeSeconds).ToString();
            }
            if (SaveScript.RaceTimeSeconds >= 10)
            {
                Seconds.text = Mathf.Round(SaveScript.RaceTimeSeconds).ToString();
            }
        }
        #endregion
    }
}
