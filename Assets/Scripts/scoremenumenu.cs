using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoremenumenu : MonoBehaviour
{
    public GameObject ScoreUIBackToMenu;
    public GameObject ScoreMenuUI;

    public void BackToMenu()
    {
            ScoreMenuUI.SetActive(false);
            SceneManager.LoadScene("MainMenu");
    }     
}
