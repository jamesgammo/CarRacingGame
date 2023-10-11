using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreTimeManagerLapCompleteDB : MonoBehaviour
{
    public Text BestTimeCounter;
    //public static Text timePlayedStr;
    public static TimeSpan mintimePlayed;
    public static List<float> bestTimes = new List<float>();
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject LapCounter;
    public static int LapsDone;
	public GameObject ScoreMenuUI;
	public GameObject UserNamePanelUI;
	public GameObject TimertextUI;
	public GameObject LapLabelUI;
	public GameObject BestTimePanel;
	public Text playerDisplay;
	public GameObject Canvas;
	public Text scoreDisplay;

	// Start is called before the first frame update
	void Start()
    {
        BestTimeCounter.text = "00:00.00";
    }

	void OnTriggerEnter()
	{
		//entering the trigger 
		Debug.Log("LapCompleteTrigger Entered");
		LapsDone += 1;


		//adding the score to the aray
		if (ScoreTimeManager.elapsedTime != 0)
		{
			bestTimes.Add(ScoreTimeManager.elapsedTime);
			Debug.Log("time added to array");
		}		

		//upload laps to laps done
		//printing the best time
		if (bestTimes.Count > 0)
		{
			bestTimes.Sort();
			mintimePlayed = TimeSpan.FromSeconds(bestTimes[0]);
			string timePlayedStr = "" + mintimePlayed.ToString("mm':'ss'.'ff");
			BestTimeCounter.text = timePlayedStr;
			DBManager.score = int.Parse(mintimePlayed.ToString("mmssff"));


			//assigning the best player score to DBManager to be uploaded
			Debug.Log("The fastest score was " + DBManager.score + " Seconds... Well Done");
		}

		//if the laps are completed
		if (LapsDone == 1)
		{
			TimertextUI.SetActive(false);
			UserNamePanelUI.SetActive(false);
			ScoreTimeManager.timerGoing = false;
			LapLabelUI.SetActive(false);
			BestTimePanel.SetActive(false);
			Debug.Log("Laps Finished");
			ScoreMenuUI.SetActive(true);

			scoreDisplay.GetComponent<Text>().text = "" + DBManager.score;
			playerDisplay.GetComponent<Text>().text = "" + DBManager.username;
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












