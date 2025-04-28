using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceType : MonoBehaviour
{
    public bool TimeTrial = true; //trail
    public float GoldMinutes;
    public float GoldSeconds;
    public float SilverMinutes;
    public float SilverSeconds;
    public float BronzeMinutes;
    public float BronzeSeconds;

    // Start is called before the first frame update
    void Start()
    {
        if (TimeTrial == true)
        {
            SaveScript.TimeTrialMinutesG = GoldMinutes;
            SaveScript.TimeTrialSecondsG = GoldSeconds;
            SaveScript.TimeTrialMinutesS = SilverMinutes;
            SaveScript.TimeTrialSecondsS = SilverSeconds;
            SaveScript.TimeTrialMinutesB = BronzeMinutes;
            SaveScript.TimeTrialSecondsB = BronzeSeconds;
        }
    }

    // Update is called once per frame
    void Update()
    {
        #region Gold, Silver or Bronze
        if (SaveScript.RaceOver == true)
        {
            if(TimeTrial== true)
            {
                //Checking if the player is Gold
                if (SaveScript.RaceTimeMinutes < GoldMinutes)
                {
                    Debug.Log("Gold");
                    SaveScript.Gold = true;
                }
                if (SaveScript.RaceTimeMinutes == GoldMinutes && SaveScript.RaceTimeSeconds < GoldSeconds)
                {
                    Debug.Log("Gold");
                    SaveScript.Gold = true;
                }

                //Checking if the player is Silver
                if (SaveScript.RaceTimeMinutes < SilverMinutes)
                {
                    if(SaveScript.Gold == false) 
                    {
                        Debug.Log("Silver");
                        SaveScript.Silver = true;
                    }
                }
                if (SaveScript.RaceTimeMinutes == SilverMinutes && SaveScript.RaceTimeSeconds < SilverSeconds)
                {
                    if (SaveScript.Gold == false)
                    {
                        Debug.Log("Silver");
                        SaveScript.Silver = true;
                    }
                }

                //Checking if the player is Bronze
                if (SaveScript.RaceTimeMinutes < BronzeMinutes)
                {
                    if (SaveScript.Gold == false && SaveScript.Silver == false)
                    {
                        Debug.Log("Bronze");
                        SaveScript.Bronze = true;
                    }
                }
                if (SaveScript.RaceTimeMinutes == BronzeMinutes && SaveScript.RaceTimeSeconds < BronzeSeconds)
                {
                    if (SaveScript.Gold == false && SaveScript.Silver == false)
                    {
                        Debug.Log("Bronze");
                        SaveScript.Bronze = true;
                    }
                }
                 else if (SaveScript.Gold == false && SaveScript.Silver == false && SaveScript.Bronze == false)
                {
                    Debug.Log("Not a Winner");
                    SaveScript.Fail = true;
                }
            }
        }
        #endregion
    }
}
