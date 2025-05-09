using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPositions : MonoBehaviour
{
    //Dynamic leaderboard updates
    [Header("Leaderboard Positions")]
    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject Slot5;
    public GameObject Slot6;
    public GameObject Slot7;

    public GameObject Stats;

    public int AICarNumber;
    public bool Player;
    private int Pos;

    // Start is called before the first frame update
    void Start()
    {
        if(AICarNumber == 1)
        {
            Pos = FinishLineAI.AICar1FinishPosition;
        }
        if (AICarNumber == 2)
        {
            Pos = FinishLineAI.AICar2FinishPosition;
        }
        if (AICarNumber == 3)
        {
            Pos = FinishLineAI.AICar3FinishPosition;
        }
        if (AICarNumber == 4)
        {
            Pos = FinishLineAI.AICar4FinishPosition;
        }
        if (AICarNumber == 5)
        {
            Pos = FinishLineAI.AICar5FinishPosition;
        }
        if (AICarNumber == 6)
        {
            Pos = FinishLineAI.AICar6FinishPosition;
        }
        if (AICarNumber == 7)
        {
            Pos = FinishLineAI.AICar7FinishPosition;
        }
        if (Player == true)
        {
            Pos = FinishLine.PlayerFinishPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Pos == 0)
        {
            Stats.SetActive(false);
        }
        if (Pos == 1) 
        { 
            Stats.transform.position = Slot1.transform.position;
        }
        if (Pos == 2)
        {
            Stats.transform.position = Slot2.transform.position;
        }
        if (Pos == 3)
        {
            Stats.transform.position = Slot3.transform.position;
        }
        if (Pos == 4)
        {
            Stats.transform.position = Slot4.transform.position;
        }
        if (Pos == 5)
        {
            Stats.transform.position = Slot5.transform.position;
        }
        if (Pos == 6)
        {
            Stats.transform.position = Slot6.transform.position;
        }
        if (Pos == 7)
        {
            Stats.transform.position = Slot7.transform.position;
        }
    }
}
