using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public Text UsernameDisplay;

    public void Awake()
    {
        if (DBManager.username == null);
        {
            SceneManager.LoadScene("MainMenu");
        }
           
        UsernameDisplay.text = "" + DBManager.username; 
        
    }
}
