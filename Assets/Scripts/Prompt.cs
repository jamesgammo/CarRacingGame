using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prompt : MonoBehaviour {
	
    public Text playerDisplay;
	
	private void Start()
	{
		if (DBManager.LoggedIn)
		{
			playerDisplay.text = "Player: " + DBManager.username;
		}
	}
}
