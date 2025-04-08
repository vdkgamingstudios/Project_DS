using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
    private float DisplaySpeed;
    public int TotalLaps = 3;

    //UI Display for variables relating to speed, time and lap count. 
    public Image SpeedRing;
    public TMP_Text SpeedText;
    public TMP_Text LapCountText;
    public TMP_Text TotalLapCountText;
    public TMP_Text LapTimeMinutesText;
    public TMP_Text LapTimeSecondsText;
    public TMP_Text RaceTimeMinutesText;
    public TMP_Text RaceTimeSecondsText;
    public TMP_Text BestLapTimeMinutesText;
    public TMP_Text BestLapTimeSecondsText;
    public TMP_Text CheckPointTime;
    public GameObject CheckPointDisplay;
    public GameObject NewLapRecordDisplay;

    // Start is called before the first frame update
    void Start()
    {
        SpeedRing.fillAmount = 0;
        SpeedText.text = "0";
        LapCountText.text = "0";
        TotalLapCountText.text = "/" + TotalLaps.ToString();
        CheckPointDisplay.SetActive(false);
        NewLapRecordDisplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Speedometer visual
        DisplaySpeed = SaveScript.Speed / SaveScript.TopSpeed;
        SpeedRing.fillAmount = DisplaySpeed;
        SpeedText.text = (Mathf.Round(SaveScript.Speed).ToString()); //Round the float number
       
        //Lap Count
        LapCountText.text = SaveScript.LapCount.ToString();

        #region Lap Time Display Setup
        //Lap Time - Minutes
        if (SaveScript.LapTimeMinutes <= 9)
        {
            LapTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }
        else if (SaveScript.LapTimeMinutes >= 10)
        {
            LapTimeMinutesText.text = (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }

        //Lap Time - Seconds
        if (SaveScript.LapTimeSeconds <= 9)
        {
            LapTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }
        else if (SaveScript.LapTimeSeconds >= 10)
        {
            LapTimeSecondsText.text = (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }
        #endregion
        #region Race Time Display Setup
        //Race Time - Minutes
        if (SaveScript.RaceTimeMinutes <= 9)
        {
            RaceTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + ":";
        }
        else if (SaveScript.RaceTimeMinutes >= 10)
        {
            RaceTimeMinutesText.text = (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + ":";
        }

        //Race Time - Seconds
        if (SaveScript.RaceTimeSeconds <= 9)
        {
            RaceTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }
        else if (SaveScript.RaceTimeSeconds >= 10)
        {
            RaceTimeSecondsText.text = (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }
        #endregion
        #region Best Lap Time Display Setup
        //Working out best lap time
        //Determine the best time in seconds
        if(SaveScript.LapChange == true)//Prevents constant checking
        {
            if (SaveScript.LastLapMinutes == SaveScript.BestLapTimeMinutes)
            {
                if (SaveScript.LastLapSeconds < SaveScript.BestLapTimeSeconds)
                {
                    SaveScript.BestLapTimeSeconds = SaveScript.LastLapSeconds;
                    SaveScript.NewRecord = true;
                }
            }

            //Determine the best time in minutes
            if (SaveScript.LastLapMinutes < SaveScript.BestLapTimeMinutes)
            {
                SaveScript.BestLapTimeMinutes = SaveScript.LastLapMinutes;
                SaveScript.BestLapTimeSeconds = SaveScript.LastLapSeconds;
                SaveScript.NewRecord = true;
            }
        }

        //Best Lap time - Minutes
        if (SaveScript.BestLapTimeMinutes <= 9)
        {
            BestLapTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.BestLapTimeMinutes).ToString()) + ":";
        }
        else if (SaveScript.BestLapTimeMinutes >= 10)
        {
            BestLapTimeMinutesText.text = (Mathf.Round(SaveScript.BestLapTimeMinutes).ToString()) + ":";
        }

        //Best Lap time - Seconds
        if (SaveScript.BestLapTimeSeconds <= 9)
        {
            BestLapTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.BestLapTimeSeconds).ToString());
        }
        else if (SaveScript.BestLapTimeSeconds >= 10)
        {
            BestLapTimeSecondsText.text = (Mathf.Round(SaveScript.BestLapTimeSeconds).ToString());
        }

        if(SaveScript.NewRecord == true)
        {
            NewLapRecordDisplay.SetActive(true);
            StartCoroutine(LapRecordOff());
        }
        #endregion
        #region CheckPoint Setup (Faster or Slower)
        //CheckPoint Working Out
        //Check Point 1 
        if(SaveScript.CheckPointPass1 == true)
        {
            SaveScript.CheckPointPass1 = false;
            if(SaveScript.LapCount > 1)
            {
                CheckPointDisplay.SetActive(true);

                //Doing worse with the lap time compared to before
                if (SaveScript.ThisCheckPoint1 > SaveScript.LastCheckPoint1)
                {
                    CheckPointTime.color = Color.red;
                    CheckPointTime.text = "-" + (Mathf.Round(SaveScript.ThisCheckPoint1 - SaveScript.LastCheckPoint1)).ToString(); //Mathf added to round the number
                    StartCoroutine(CheckPointOff());
                }

                //Doing better with the lap time compared to before
                if (SaveScript.ThisCheckPoint1 < SaveScript.LastCheckPoint1)
                {
                    CheckPointTime.color = Color.green;
                    CheckPointTime.text = "+" + (Mathf.Round(SaveScript.LastCheckPoint1 - SaveScript.ThisCheckPoint1)).ToString(); //Mathf added to round the number
                    StartCoroutine(CheckPointOff());
                }
            } 
        }

        //Check Point 2 
        if (SaveScript.CheckPointPass2 == true)
        {
            SaveScript.CheckPointPass2 = false;
            if (SaveScript.LapCount > 1) 
            {
                CheckPointDisplay.SetActive(true);

                //Doing worse with the lap time compared to before
                if (SaveScript.ThisCheckPoint2 > SaveScript.LastCheckPoint2)
                {
                    CheckPointTime.color = Color.red;
                    CheckPointTime.text = "-" + (Mathf.Round(SaveScript.ThisCheckPoint2 - SaveScript.LastCheckPoint2)).ToString();//Mathf added to round the number
                    StartCoroutine(CheckPointOff());
                }

                //Doing better with the lap time compared to before
                if (SaveScript.ThisCheckPoint2 < SaveScript.LastCheckPoint2)
                {
                    CheckPointTime.color = Color.green;
                    CheckPointTime.text = "+" + (Mathf.Round(SaveScript.LastCheckPoint2 - SaveScript.ThisCheckPoint2)).ToString();//Mathf added to round the number
                    StartCoroutine(CheckPointOff());
                }
            }
        }
        #endregion
    }

    IEnumerator CheckPointOff()
    {
        yield return new WaitForSeconds(2);
        CheckPointDisplay.SetActive(false);
    }

    IEnumerator LapRecordOff()
    {
        yield return new WaitForSeconds(2);
        SaveScript.NewRecord = false;
        NewLapRecordDisplay.SetActive(false);
    }
}
