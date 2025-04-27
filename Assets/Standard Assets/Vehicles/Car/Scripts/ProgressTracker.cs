using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    private AudioSource Player;
    private bool IsPlaying = false;
    public int CurrentWP = 0;
    public int ThisWPNumber;
    public int LastWPNumber;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Barrier")) 
        {
            if (IsPlaying == false)
            {
                IsPlaying = true;
                Player.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Barrier"))
        {
            if (IsPlaying == true)
            {
                IsPlaying = false;
            }
        }
    }

    private void Update()
    {
        if (CurrentWP > LastWPNumber) 
        {
            StartCoroutine(CheckDirection());
        }
        if(LastWPNumber > ThisWPNumber) 
        {
            //Debug.Log("Right Way");
            SaveScript.WrongWay = false;
        }
        if (LastWPNumber < ThisWPNumber)
        {
            //Debug.Log("Wrong Way");
            SaveScript.WrongWay = true;
        }
    }

    IEnumerator CheckDirection()
    {
        yield return new WaitForSeconds(0.5f);  
        ThisWPNumber = LastWPNumber;
    }
}
