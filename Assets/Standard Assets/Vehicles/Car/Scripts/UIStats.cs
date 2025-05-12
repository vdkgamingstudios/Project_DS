using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStats : MonoBehaviour
{
    //Placement in Race
    [Header("Player Stats")]
    public TMP_Text NameDisplay;
    public TMP_Text NewName;
    public TMP_Text RacesWonDisplay;
    public TMP_Text RacesLostDisplay;
    public GameObject InputField;
    private bool DisplayChange = false;//public originally
    public GameObject StatsPanel;

    void Start()
    {
        InputField.SetActive(false);
        StartCoroutine(UpdateStats());
    }

    void Update()
    {
        if (DisplayChange == true)
        {
            DisplayChange = false;
            StartCoroutine(UpdateStats());
        }
    }

    IEnumerator UpdateStats()
    {
        yield return new WaitForSeconds(0.05f);
        NameDisplay.text = UniversalSave.PlayerName;
        RacesWonDisplay.text = UniversalSave.RacesWon.ToString();
        RacesLostDisplay.text = UniversalSave.RacesLost.ToString();
    }

    public void ChangeName()
    {
        UniversalSave.PlayerName = NewName.text;
        UniversalSave.Saving = true;
        DisplayChange = true;
        InputField.SetActive(false);
    }

    public void EditName()
    {
        InputField.SetActive(true);
    }

    public void SwitchOffStats()
    {
        StatsPanel.SetActive(false);
    }
}
