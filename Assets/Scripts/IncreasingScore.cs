using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingScore : MonoBehaviour
{
    public GameObject IncreaseScorePanel;
    public GameObject ScoreMenuUI;

    public void ScoreMenu()
    {
        ScoreMenuUI.SetActive(true);
        IncreaseScorePanel.SetActive(false);
    }
}
