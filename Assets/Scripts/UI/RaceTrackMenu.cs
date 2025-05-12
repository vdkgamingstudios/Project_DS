using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTrackMenu : MonoBehaviour
{
    public GameObject TrackOptions;

    public void OptionsOn()
    {
        TrackOptions.SetActive(true);
    }

    public void OptionsOff()
    {
        TrackOptions.SetActive(false);
    }
}
