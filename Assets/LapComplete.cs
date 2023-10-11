using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LapComplete : MonoBehaviour
{
	//publicDisplay 
	public Text BestTimeCounter;
	public GameObject ScoreMenu;
	public GameObject bestTimeGamePanel;
	public GameObject LapCounterPanel;
	public static int LapsDone;
	public GameObject MoveMap;
	public GameObject currentTimerPanel;

	//sorting bestTime 
	public static TimeSpan mintimePlayed;
	public static List<float> bestTimes = new List<float>();

	//laptriggers 
	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	//BestTimePanel
	public Text playerDisplay;
	public Text scoreDisplay;

	public static string time;

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
			time = "" + mintimePlayed.ToString("mm':'ss'.'ff");
			BestTimeCounter.text = time;

			Debug.Log("The fastest score was " + time + " Seconds... Well Done");

		}

		//if the laps completed 
		if (LapsDone == 3)
		{
			// things being activated
			scoreDisplay.GetComponent<Text>().text = "" + time;
			playerDisplay.GetComponent<Text>().text = "" + DBManager.username;


			ScoreMenu.SetActive(true);

			//things being deactivated 
			bestTimeGamePanel.SetActive(false);
			LapCounterPanel.SetActive(false);
			currentTimerPanel.SetActive(false);
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
		LapCounterPanel.GetComponent<Text>().text = "" + LapsDone;
	}

}
