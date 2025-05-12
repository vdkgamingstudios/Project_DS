using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeTrialUI : MonoBehaviour
{
    //Time Trial ranking 
    [Header("Time Trial Ranking")]
    public TMP_Text TimeTrialMinutesGTxt;
    public TMP_Text TimeTrialSecondsGTxt;
    public TMP_Text TimeTrialMinutesSTxt;
    public TMP_Text TimeTrialSecondsSTxt;
    public TMP_Text TimeTrialMinutesBTxt;
    public TMP_Text TimeTrialSecondsBTxt;
    public TMP_Text WinMessage;
    public TMP_Text Credits;

    //Time Trial game object
    [Header("Time Trial Related Game Object")]
    public GameObject TimeTrialObject;
    public GameObject TimeTrialResults;
    public GameObject GoldStar;
    public GameObject SilverStar;
    public GameObject BronzeStar;
    public int GoldCredits = 200;
    public int SilverCredits = 150;
    public int BronzeCredits = 100;

    public GameObject QuitPanel;

    //Variables to hold time trial values
    public bool Winner = false;

    // Start is called before the first frame update
    void Start()
    {
        TimeTrialObject.SetActive(true);
        TimeTrialResults.SetActive(false);
        QuitPanel.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        #region Time Trials
        //Setting the time for gold in the time trials
        if (SaveScript.TimeTrialMinutesG <= 9)
        {
            TimeTrialMinutesGTxt.text = "0" + SaveScript.TimeTrialMinutesG.ToString() + ":";
        }
        if (SaveScript.TimeTrialMinutesG >= 10)
        {
            TimeTrialMinutesGTxt.text = SaveScript.TimeTrialMinutesG.ToString() + ":";
        }
        if (SaveScript.TimeTrialSecondsG <= 9)
        {
            TimeTrialSecondsGTxt.text = "0" + SaveScript.TimeTrialSecondsG.ToString();
        }
        if (SaveScript.TimeTrialSecondsG >= 10)
        {
            TimeTrialSecondsGTxt.text = SaveScript.TimeTrialSecondsG.ToString();
        }

        //Setting the time for Silver in the time trials
        if (SaveScript.TimeTrialMinutesS <= 9)
        {
            TimeTrialMinutesSTxt.text = "0" + SaveScript.TimeTrialMinutesS.ToString() + ":";
        }
        if (SaveScript.TimeTrialMinutesS >= 10)
        {
            TimeTrialMinutesSTxt.text = SaveScript.TimeTrialMinutesS.ToString() + ":";
        }
        if (SaveScript.TimeTrialSecondsS <= 9)
        {
            TimeTrialSecondsSTxt.text = "0" + SaveScript.TimeTrialSecondsS.ToString();
        }
        if (SaveScript.TimeTrialSecondsS >= 10)
        {
            TimeTrialSecondsSTxt.text = SaveScript.TimeTrialSecondsS.ToString();
        }

        //Setting the time for Bronze in the time trials
        if (SaveScript.TimeTrialMinutesB <= 9)
        {
            TimeTrialMinutesBTxt.text = "0" + SaveScript.TimeTrialMinutesB.ToString() + ":";
        }
        if (SaveScript.TimeTrialMinutesB >= 10)
        {
            TimeTrialMinutesBTxt.text = SaveScript.TimeTrialMinutesB.ToString() + ":";
        }
        if (SaveScript.TimeTrialSecondsB <= 9)
        {
            TimeTrialSecondsBTxt.text = "0" + SaveScript.TimeTrialSecondsB.ToString();
        }
        if (SaveScript.TimeTrialSecondsB >= 10)
        {
            TimeTrialSecondsBTxt.text = SaveScript.TimeTrialSecondsB.ToString();
        }
        #endregion

        #region Finish Race
        if (SaveScript.RaceOver == true)
        {
            if(Winner == false)
            {
                Winner = true;
                StartCoroutine(ResultsMessage());
            }
        }

        #endregion

        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            QuitPanel.SetActive(true);
        }
    }

    IEnumerator ResultsMessage()
    {
        yield return new WaitForSeconds(0.15f); 

        TimeTrialResults.SetActive(true);

        //Look at else if or switch for this later on
        if(SaveScript.Gold == true)
        {
            WinMessage.text = "YOU WON GOLD!";
            GoldStar.SetActive(true);
            Credits.text = GoldCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += GoldCredits;
            UniversalSave.RacesWon++;
        }
        if (SaveScript.Silver == true)
        {
            WinMessage.text = "YOU WON SILVER!";
            SilverStar.SetActive(true);
            Credits.text = SilverCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += SilverCredits;
            UniversalSave.RacesWon++;
        }
        if (SaveScript.Bronze == true)
        {
            WinMessage.text = "YOU WON BRONZE!";
            BronzeStar.SetActive(true);
            Credits.text = BronzeCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += BronzeCredits;
            UniversalSave.RacesWon++;
        }
        if (SaveScript.Fail == true)
        {
            WinMessage.text = "TRY AGAIN";
            Credits.text = "0";
            UniversalSave.RacesLost++;
        }

        UniversalSave.Saving = true;
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitClose()
    {
        QuitPanel.SetActive(false);
    }
}
