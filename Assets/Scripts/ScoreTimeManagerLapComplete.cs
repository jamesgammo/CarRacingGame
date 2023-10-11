using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreTimeManagerLapComplete : MonoBehaviour
{
	//publicDisplay 
	public Text BestTimeCounter;

	//sorting bestTime 
	public static TimeSpan mintimePlayed;
	public static List<float> bestTimes = new List<float>();
	
	//laptriggers 
	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	//laps counter 
	public GameObject LapCounter;
	public static int LapsDone;

	//defined for the pauseMenu 
	public GameObject ScoreMenu;
	public GameObject UserNamePanelUI;
	public GameObject TimertextUI;
	public GameObject LapLabelUI;
	public GameObject BestTimePanel;
	public GameObject MoveMap;
	public Text playerDisplay;
	public Text scoreDisplay;

	void Start()
	{
		BestTimeCounter.text = "00:00.00";
	}

	void OnTriggerEnter()
	{
		//increasing the amount of laps
		LapsDone += 1;

		//entering the trigger 
		Debug.Log("LapCompleteTrigger Entered");

		//adding time to the array
		if (ScoreTimeManager.elapsedTime != 0)
		{
			bestTimes.Add(ScoreTimeManager.elapsedTime);
			Debug.Log("Time added to array");
		}

		//upload laps to laps done
		if (bestTimes.Count > 0)
		{
			bestTimes.Sort();

			mintimePlayed = TimeSpan.FromSeconds(bestTimes[0]);
			DBManager.scoreee = "" + mintimePlayed.ToString("mm':'ss'.'ff");
			BestTimeCounter.text = DBManager.scoreee;

			Debug.Log("The fastest score was " + DBManager.scoreee + " Seconds... Well Done");

		}

		//if the laps completed 
		if (LapsDone == 1)
		{
			// things being activated
			scoreDisplay.GetComponent<Text>().text = "" + DBManager.scoreee;
			playerDisplay.GetComponent<Text>().text = "" + DBManager.username;
			ScoreMenu.SetActive(true);

			//things being deactivated 
			TimertextUI.SetActive(false);
			UserNamePanelUI.SetActive(false);
			ScoreTimeManager.timerGoing = false;
			LapLabelUI.SetActive(false);
			BestTimePanel.SetActive(false);
			MoveMap.SetActive(false);

			//Debug.Log
			Debug.Log("Laps Finished");
		}

		//set timer back to 0 
		ScoreTimeManager.elapsedTime = 0;

		//set half lap trigger
		HalfLapTrig.SetActive(true);
		// set lap complete trigger 
		LapCompleteTrig.SetActive(false);
		LapCounter.GetComponent<Text>().text = "" + LapsDone;
	}
}

