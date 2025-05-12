using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    //Placement in Race
    [Header("Player Credits")]
    public TMP_Text CreditsText;

    public GameObject StatsPanel;

    private void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(WaitForCredits());
    }

    IEnumerator WaitForCredits()
    {
        yield return new WaitForSeconds(0.2f);
        CreditsText.text = UniversalSave.CreditAmount.ToString();
    }

    public void SwitchOnStats()
    {
        StatsPanel.SetActive(true);
    }
}
