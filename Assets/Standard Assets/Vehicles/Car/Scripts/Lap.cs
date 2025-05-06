using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SaveScript.WWDisplayReset = true;
            StartCoroutine(WrongWayReset());

            if (SaveScript.RaceOver == false)
            {
                if (SaveScript.HalfWayActivated == true)
                {
                    SaveScript.HalfWayActivated = false;
                    //SaveScript.WWDisplayReset = true;
                    SaveScript.LastLapMinutes = SaveScript.LapTimeMinutes;
                    SaveScript.LastLapSeconds = SaveScript.LapTimeSeconds;
                    SaveScript.LapCount++;
                    SaveScript.LapChange = true;

                    if (SaveScript.LapCount == 2)
                    {
                        SaveScript.BestLapTimeMinutes = SaveScript.LastLapMinutes;
                        SaveScript.BestLapTimeSeconds = SaveScript.LastLapSeconds;
                        SaveScript.NewRecord = true;
                    }

                    SaveScript.CheckPointPass1 = false;
                    SaveScript.CheckPointPass2 = false;
                    SaveScript.LastCheckPoint1 = SaveScript.ThisCheckPoint1;
                    SaveScript.LastCheckPoint2 = SaveScript.ThisCheckPoint2;
                    //StartCoroutine(WrongWayReset());
                }
            }
        }

        #region AI Lap Count Increase
        if (other.gameObject.CompareTag("ProgressAI1"))
        {
            SaveScript.AICar1LapNumber++;
        }
        if (other.gameObject.CompareTag("ProgressAI2"))
        {
            SaveScript.AICar2LapNumber++;
        }
        if (other.gameObject.CompareTag("ProgressAI3"))
        {
            SaveScript.AICar3LapNumber++;
        }
        if (other.gameObject.CompareTag("ProgressAI4"))
        {
            SaveScript.AICar4LapNumber++;
        }
        if (other.gameObject.CompareTag("ProgressAI5"))
        {
            SaveScript.AICar5LapNumber++;
        }
        if (other.gameObject.CompareTag("ProgressAI6"))
        {
            SaveScript.AICar6LapNumber++;
        }
        if (other.gameObject.CompareTag("ProgressAI7"))
        {
            SaveScript.AICar7LapNumber++;
        }
        #endregion
    }

    IEnumerator WrongWayReset()
    {
        yield return new WaitForSeconds(1.5f);
        SaveScript.WWDisplayReset = false;
    }
}
