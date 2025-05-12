using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenuScript : MonoBehaviour
{
    [Header("Options Menu Variables")]
    public TMP_Text Mode;
    public TMP_Text LapCount;
    public TMP_Text OpponentCount;

    private bool TimeTrial = true;
    private int CurrentLapCount = 1;
    private int CurrentOpponentCount = 1;
    public int TimeTrialSceneNumber;
    public int RaceTrackSceneNumber;
    public GameObject LoadScreen;
    public GameObject OpponentsOn;
    public GameObject LapsOn;

    #region Game Mode
    public void ModeNext()
    {
        if (TimeTrial == true)
        {
            Mode.text = "RACE";
            TimeTrial = false;
            OpponentsOn.SetActive(true);
            LapsOn.SetActive(true);
        }
    }

    public void ModeBack()
    {
        if (TimeTrial == false)
        {
            Mode.text = "TIME TRIAL";
            TimeTrial = true;
            OpponentsOn.SetActive(false);
            LapsOn.SetActive(false);
        }
    }
    #endregion

    #region Lap Amount
    public void LapCountNext()
    {
        if(CurrentLapCount < 12)
        {
            CurrentLapCount++;
            LapCount.text = CurrentLapCount.ToString() + " LAPS";
            UniversalSave.LapCounts = CurrentLapCount;
        }
    }

    public void LapCountBack()
    {
        if (CurrentLapCount > 2)
        {
            CurrentLapCount--;
            LapCount.text = CurrentLapCount.ToString() + " LAPS";
            UniversalSave.LapCounts = CurrentLapCount;
        }
        else if(CurrentLapCount == 2)
        {
            CurrentLapCount--;
            LapCount.text = CurrentLapCount.ToString() + " LAP";
            UniversalSave.LapCounts = CurrentLapCount;
        }
    }
    #endregion

    #region Opponent Amount
    public void OpponentsNext()
    {
        if (CurrentOpponentCount < 7)
        {
            CurrentOpponentCount++;
            OpponentCount.text = CurrentOpponentCount.ToString() + " OPPONENTS";
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
    }

    public void OpponentsBack()
    {
        if (CurrentOpponentCount > 2)
        {
            CurrentOpponentCount--;
            OpponentCount.text = CurrentOpponentCount.ToString() + " OPPONENTS";
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
        else if (CurrentOpponentCount == 2)
        {
            CurrentOpponentCount--;
            OpponentCount.text = CurrentOpponentCount.ToString() + " OPPONENT";
            UniversalSave.OpponentsCount = CurrentOpponentCount;
        }
    }
    #endregion

    public void BeginRace()
    {
        if(TimeTrial == true)
        {
            StartCoroutine(WaitToLoad());
        }
        if (TimeTrial == false)
        {
            StartCoroutine(WaitToLoad2());
        }
    }

    void ResetValues() 
    {
        Time.timeScale = 1.0f;
        SaveScript.LapCount = 0;
        SaveScript.LapChange = false;
        SaveScript.LapTimeMinutes = 0.0f;
        SaveScript.LapTimeSeconds = 0.0f;
        SaveScript.RaceTimeMinutes = 0.0f;
        SaveScript.RaceTimeSeconds = 0.0f;
        SaveScript.LastLapMinutes = 0.0f;
        SaveScript.LastLapSeconds = 0.0f;
        SaveScript.GameTime = 0.0f;
        SaveScript.LastCheckPoint1 = 0.0f; 
        SaveScript.LastCheckPoint2 = 0.0f;
        SaveScript.ThisCheckPoint1 = 0.0f;
        SaveScript.ThisCheckPoint2 = 0.0f;
        SaveScript.CheckPointPass1 = false;
        SaveScript.CheckPointPass2 = false;
        SaveScript.HalfWayActivated = true;
        SaveScript.RaceStart = false;
        SaveScript.RaceOver = false;
        SaveScript.PlayerPosition = 0;
        SaveScript.Gold = false;
        SaveScript.Silver = false;
        SaveScript.Bronze = false;
        SaveScript.Fail = false;
        SaveScript.AICar1LapNumber = 0;
        SaveScript.AICar2LapNumber = 0;
        SaveScript.AICar3LapNumber = 0;
        SaveScript.AICar4LapNumber = 0;
        SaveScript.AICar5LapNumber = 0;
        SaveScript.AICar6LapNumber = 0;
        SaveScript.AICar7LapNumber = 0;
        SaveScript.FinishPositionID = 0;
    }

    IEnumerator WaitToLoad()
    {
        ResetValues();
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        UniversalSave.LapCounts = 1;
        UniversalSave.OpponentsCount = 0;
        SceneManager.LoadScene(TimeTrialSceneNumber);
    }

    IEnumerator WaitToLoad2()
    {
        ResetValues();
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        UniversalSave.LapCounts = CurrentLapCount;
        UniversalSave.OpponentsCount = CurrentOpponentCount;
        SceneManager.LoadScene(RaceTrackSceneNumber);
    }
}
