/*sing System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeManagerLapComplete : MonoBehaviour
{
	
	List<float> bestTimes = new List<float>();

	public Text BestTimeCounter;
	public static TimeSpan mintimePlayed;


	//LapCompleteTrig
	public GameObject LapCompleteTrig;
	//HalfLapTrig
	public GameObject HalfLapTrig;
	//time playing from TimeManager Script
	
	public GameObject LapCounter; 
	public int LapsDone;

	void Start()
	{
		BestTimeCounter.text = "00:00.0";
	}
	
	void OnTriggerEnter () 
	{
		
		Debug.Log("LapCompleteTrigger Entered");
		LapsDone+=1;
		Debug.Log("LapsDone");
		
		if (ScoreTimeManager.elapsedTime !=0)
		{
			bestTimes.Add(ScoreTimeManager.elapsedTime);
			Debug.Log("time added to array");
		}
		
		//upload laps to laps done
		if (bestTimes.Count > 0)
		{
			bestTimes.Sort();
			//BestTimeCounter.GetComponent<Text>().text = "" + bestTimes[0].ToString();
			//string BestTimeCounter = "Time: " + bestTimes[0].ToString("mm':'ss'.'ff");
			//timeFormat.text = BestTimeCounter;

			//TimeManager.elapsedTime 
			mintimePlayed = TimeSpan.FromSeconds(bestTimes[0]);
			string timePlayedStr = "" + mintimePlayed.ToString("mm':'ss'.'ff");
			BestTimeCounter.text = timePlayedStr;

		}


		//bestPlaying = bestTimes[0];
		//string fastestTime = "Time: " + bestPlaying.ToString("mm':'ss'.'ff");
		//BestTimeCounter.text = timeFormat.text

		//set timer back to 0 
		ScoreTimeManager.elapsedTime = 0;
			
		//set half lap trigger
		HalfLapTrig.SetActive(true);
		// set lap complete trigger 
		LapCompleteTrig.SetActive(false);
		LapCounter.GetComponent<Text>().text = ""+ LapsDone;
    }
}
*/
