using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    //Time Trial game object
    [Header("Time Trial Related Game Object")]
    public GameObject TimeTrialObject;

    // Start is called before the first frame update
    void Start()
    {
        TimeTrialObject.SetActive(true);
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
    }
}
