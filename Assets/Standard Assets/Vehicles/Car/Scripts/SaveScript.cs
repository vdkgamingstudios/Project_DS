using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class SaveScript : MonoBehaviour
{
    public static float Speed;
    public static float TopSpeed;
    public static int LapCount;
    public static bool LapChange = false;

    //Time related UI variables
    public static float LapTimeMinutes;
    public static float LapTimeSeconds;
    public static float RaceTimeMinutes;
    public static float RaceTimeSeconds;
    public static float BestLapTimeMinutes;
    public static float BestLapTimeSeconds;
    public static float LastLapMinutes;
    public static float LastLapSeconds;
    public static bool NewRecord = false;

    //Checkpoint times
    public static float GameTime;
    public static float LastCheckPoint1;
    public static float ThisCheckPoint1;
    public static float LastCheckPoint2;
    public static float ThisCheckPoint2;
    public static bool CheckPointPass1 = false;
    public static bool CheckPointPass2 = false;

    //Terrain changes
    public static bool OnTheRoad = true;
    public static bool OnTheTerrain = false;
    public static bool WrongWay = false;

    //Lap Tracker
    public static bool HalfWayActivated = true;
    public static bool WWDisplayReset = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LapChange == true)
        {
            LapChange = false;
            LapTimeMinutes = 0f;
            LapTimeSeconds = 0f;
            GameTime = 0f;
        }

        if(LapCount >= 1)
        {
            LapTimeSeconds = LapTimeSeconds + 1 * Time.deltaTime;
            RaceTimeSeconds = RaceTimeSeconds + 1 * Time.deltaTime;
            GameTime = GameTime + 1 * Time.deltaTime; 
        }

        if (LapTimeSeconds > 59) 
        {
            LapTimeSeconds = 0f;
            LapTimeMinutes++;
        }

        if (RaceTimeSeconds > 59)
        {
            RaceTimeSeconds = 0f;
            RaceTimeMinutes++;
        }
    }
}
