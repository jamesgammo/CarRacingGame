using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UsernameDisplay : MonoBehaviour
{ 
    public Text playerDisplay;

    public void Start()
    {
        if (DBManager.username == null)
        {
            SceneManager.LoadScene("MainMenu");
        }

        playerDisplay.text = "" + DBManager.username;
    }

}
