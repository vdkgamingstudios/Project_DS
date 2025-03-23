using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingMenu : MonoBehaviour
{
    //Variables for audio
    public AudioMixer audioMixer;

    //Game resolution variables //Normal Dropdown or TMPro.TMP_Dropdown
    public TMPro.TMP_Dropdown resolutionDropdown; 
    Resolution[] resolutions;

    void Start()
    {
        //Gathering screen resolution options
        resolutions = Screen.resolutions;

        //Clearing the basic list to an accurate one
        resolutionDropdown.ClearOptions();

        //List of resolutions
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        //Adding resolutions to the dropdown
        for (int i = 0; i < resolutions.Length; i++)
        { 
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        //Resolution updates
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

        Debug.Log("Resolution changed");
    }

    //Setting the audio mixer basec on volume
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        Debug.Log(volume);
    }

    //Graphics quality
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    //Fullscreen toggle
    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        Debug.Log(isFullscreen);
    }
}
