using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour
{
    public Text playerDisplay;
    public Text scoreDisplay;

    private void Awake()
    {
        //player not logged in is returned to the main menu
        if (DBManager.username == null)
        {
            SceneManager.LoadScene("MainMenu");
        }

        playerDisplay.GetComponent<Text>().text = "" + DBManager.username;
        scoreDisplay.GetComponent<Text>().text = "" + DBManager.scoreee;

    }
}
    

    









