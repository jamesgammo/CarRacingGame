using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserDisplay : MonoBehaviour
{
    public Text playerDisplay;

    private void Awake()
    {
        if (DBManager.username == null);
        {
           SceneManager.LoadScene("MainMenu");
        }

        playerDisplay.GetComponent<Text>().text = "" + DBManager.username;
        
    }
}
