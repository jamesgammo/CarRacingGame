using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loggedinplayer : MonoBehaviour
{
    public Text PlayerDisplayText;

    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            PlayerDisplayText.text = "Player: " + DBManager.username;
        }
    }        
}
