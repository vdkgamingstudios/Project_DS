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

    IEnumerator WrongWayReset()
    {
        yield return new WaitForSeconds(1.5f);
        SaveScript.WWDisplayReset = false;
    }
}
