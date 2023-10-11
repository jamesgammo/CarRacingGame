using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIdisable : MonoBehaviour
{
    public GameObject UserNamePanelUI;
    public GameObject IncreaseScorePanel;
    public GameObject pauseMenuUI;
    public GameObject ScoreMenuUI;
    public GameObject TimertextUI;
    public GameObject LapLabelUI;
    public GameObject BestTimePanel;

    void OnTriggerEnter()
    {
        //if (ScoreTimeManagerLapCompleteDB.LapsDone == 1)
        if (ScoreTimeManagerLapCompleteDB.LapsDone == 1)
        {
            pauseMenuUI.SetActive(false);
            TimertextUI.SetActive(false);
            UserNamePanelUI.SetActive(false);
            pauseMenuUI.SetActive(false);
            ScoreTimeManager.timerGoing = false;
            LapLabelUI.SetActive(false);
            BestTimePanel.SetActive(false);
            IncreaseScorePanel.SetActive(true); 
            Debug.Log("Laps Finished");
        }
    }

    public void ScoreMenu()
    {
        ScoreMenuUI.SetActive(true);
        IncreaseScorePanel.SetActive(false);
    }
}
