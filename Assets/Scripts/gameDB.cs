using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class gameDB : MonoBehaviour
{
    public Text playerDisplay;
    public Text scoreDisplay;

    //logs out player
    private void Awake()
    {
        if (DBManager.username == null)
        {
            SceneManager.LoadScene("MainMenu");
        }

        playerDisplay.GetComponent<Text>().text = "" + DBManager.username;
        scoreDisplay.GetComponent<Text>().text = "" + DBManager.score; 
    }
    
    //saves player data 
    public void CallSaveData()
    {
        StartCoroutine(SavePlayerData()); 
    }

    IEnumerator SavePlayerData()
    {   
        WWWForm form = new WWWForm();
        form.AddField("username", DBManager.username);
        form.AddField("score", DBManager.score);

        //uploads data to the flatfile DB
        WWW www = new WWW("http://localhost/sqlconnect/savedata.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("Game is Saved. ");
        }
        else
        {
            Debug.Log("Save Failed. Error no: " + www.text);
        }
    }
}