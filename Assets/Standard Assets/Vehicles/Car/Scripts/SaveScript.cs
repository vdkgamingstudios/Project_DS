using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class SaveScript : MonoBehaviour
{
    [Header("Speed and Laps")]
    public static float Speed;
    public static float TopSpeed;
    public static int LapCount;
    public static bool LapChange = false;

    //Time related UI variables
    [Header("Time Related UI Variables")]
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
    [Header("Checkpoint Related UI Variables")]
    public static float GameTime;
    public static float LastCheckPoint1;
    public static float ThisCheckPoint1;
    public static float LastCheckPoint2;
    public static float ThisCheckPoint2;
    public static bool CheckPointPass1 = false;
    public static bool CheckPointPass2 = false;

    //Terrain changes
    [Header("Terrain Change Checks")]
    public static bool OnTheRoad = true;
    public static bool OnTheTerrain = false;
    public static bool WrongWay = false;

    //Lap Tracker
    [Header("Lap Tracker")]
    public static bool HalfWayActivated = true;
    public static bool WWDisplayReset = false;

    //Values for checking and time related to Time Trial Races
    [Header("Time Trial Race Variables")]
    public static bool RaceStart = false;
    public static float TimeTrialMinutesG;
    public static float TimeTrialMinutesS;
    public static float TimeTrialMinutesB;
    public static float TimeTrialSecondsG;
    public static float TimeTrialSecondsS;
    public static float TimeTrialSecondsB;
    public static int MaxLaps;
    public static bool RaceOver = false;
    public static bool Gold = false;
    public static bool Silver = false;
    public static bool Bronze = false;
    public static bool Fail = false;

    //Figuring out Player position
    [Header("Player Position Variables")]
    public static int PlayerPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if the race is over 
        if(RaceOver == false)
        {
            //Only racings with time tracking the laps if the lap count is not met
            if (LapChange == true)
            {
                LapChange = false;
                LapTimeMinutes = 0f;
                LapTimeSeconds = 0f;
                GameTime = 0f;
            }

            if (LapCount >= 1)
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
}
