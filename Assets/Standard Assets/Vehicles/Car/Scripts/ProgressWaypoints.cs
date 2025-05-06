using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressWaypoints : MonoBehaviour
{
    public int WPNumber;
    public int CarTracking = 0;
    public bool PenaltyOption = false;
    public int PenaltyWayPoint;

    //Figure out car position
    public int Position = 0;

    //How many laps there are for the race
    private int Lap1Position = 0;
    private int Lap2Position = 0;
    private int Lap3Position = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Progress"))
        {
            CarTracking = other.GetComponent<ProgressTracker>().CurrentWP;

            if (CarTracking < WPNumber)
            {
                other.GetComponent<ProgressTracker>().CurrentWP = WPNumber;
                //Debug.Log("CurrentWP " + other.GetComponent<ProgressTracker>().CurrentWP);

                if(SaveScript.LapCount == 1)
                {
                    Lap1Position++;
                    SaveScript.PlayerPosition = Lap1Position;
                }
                if (SaveScript.LapCount == 2)
                {
                    Lap2Position++;
                    SaveScript.PlayerPosition = Lap2Position;
                }
                if (SaveScript.LapCount == 3)
                {
                    Lap3Position++;
                    SaveScript.PlayerPosition = Lap3Position;
                }
                //Position++;
                //SaveScript.PlayerPosition = Position;
            }

            if (CarTracking > WPNumber) 
            { 
                other.GetComponent<ProgressTracker>().LastWPNumber = WPNumber;
                //SaveScript.WrongWay = true;
                //Debug.Log("Wrong Way");
            }

            //Penalty system which is not required if users are going through shortcuts they discover
            //if (PenaltyOption == true) 
            //{
            //    if (CarTracking < PenaltyWayPoint) 
            //    {
            //        Debug.Log("Penalty");
            //    }
            //}
        }

        #region AI Lap Count For Each Car
        //AI Car One
        if (other.gameObject.CompareTag("ProgressAI1"))
        {
            if(SaveScript.AICar1LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar1LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar1LapNumber == 3)
            {
                Lap3Position++;
            }
        }
        //AI Car Two
        if (other.gameObject.CompareTag("ProgressAI2"))
        {
            if (SaveScript.AICar2LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar2LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar2LapNumber == 3)
            {
                Lap3Position++;
            }
        }
        //AI Car Three
        if (other.gameObject.CompareTag("ProgressAI3"))
        {
            if (SaveScript.AICar3LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar3LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar3LapNumber == 3)
            {
                Lap3Position++;
            }
        }
        //AI Car Four
        if (other.gameObject.CompareTag("ProgressAI4"))
        {
            if (SaveScript.AICar4LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar4LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar4LapNumber == 3)
            {
                Lap3Position++;
            }
        }
        //AI Car Five
        if (other.gameObject.CompareTag("ProgressAI5"))
        {
            if (SaveScript.AICar5LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar5LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar5LapNumber == 3)
            {
                Lap3Position++;
            }
        }
        //AI Car Six
        if (other.gameObject.CompareTag("ProgressAI6"))
        {
            if (SaveScript.AICar6LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar6LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar6LapNumber == 3)
            {
                Lap3Position++;
            }
        }
        //AI Car Seven
        if (other.gameObject.CompareTag("ProgressAI7"))
        {
            if (SaveScript.AICar7LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar7LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar7LapNumber == 3)
            {
                Lap3Position++;
            }
        }
        #endregion
    }
}
