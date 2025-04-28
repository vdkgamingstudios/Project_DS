using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLightsScript : MonoBehaviour
{
    //Light Game Objects
    public GameObject RLightOff;
    public GameObject RLightOn;
    public GameObject OLightOff;
    public GameObject OLightOn;
    public GameObject GLightOff;
    public GameObject GLightOn;

    //Sound and Go 
    public AudioSource SoundOne;
    public AudioSource SoundTwo;
    public GameObject Go;

    // Start is called before the first frame update
    void Start()
    {
        Go.SetActive(false);
        StartCoroutine(StartingLights());
    }

    IEnumerator StartingLights()
    {
        yield return new WaitForSeconds(1);
        RLightOff.SetActive(false);
        RLightOn.SetActive(true);
        SoundOne.Play();
        yield return new WaitForSeconds(1);
        RLightOff.SetActive(true);
        RLightOn.SetActive(false);
        SoundOne.Play();
        OLightOff.SetActive(false);
        OLightOn.SetActive(true);
        yield return new WaitForSeconds(1);
        OLightOff.SetActive(true);
        OLightOn.SetActive(false);
        SoundTwo.Play();
        GLightOff.SetActive(false);
        GLightOn.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        SaveScript.RaceStart = true;
        Go.SetActive(true);
        yield return new WaitForSeconds(2);
        Go.SetActive(false);
    }
}
