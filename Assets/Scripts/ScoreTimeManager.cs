using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTimeManager : MonoBehaviour
//public class TimeManager : MonoBehaviour
{
	public static ScoreTimeManager instance;
	//public static TimeManager instance;

	public Text timeCounter;
	public Text BesttimeCounter;
	public TimeSpan timePlaying;
	public static bool timerGoing;
	public static float elapsedTime;
	public int score;

	private void Awake()
	{
		instance = this; //allows to call functions from outside of the class 
	}

	// Start is called before the first frame update
	public void Start()
	{
		timeCounter.text = "Time: 00:00.00";
		BesttimeCounter.text = "00:00.00";
		timerGoing = false;
		Debug.Log("Timer Reset");

	}

	public void BeginTimer()
	{
		timerGoing = true;
		elapsedTime = 0f;

		StartCoroutine(UpdateTimer());
		Debug.Log("Timer began");
	}

	public void EndTimer()
	{
		timerGoing = false;
	}

	private IEnumerator UpdateTimer()//counts the timer for the box
	{
		while (timerGoing)
		{
			elapsedTime += Time.deltaTime;
			timePlaying = TimeSpan.FromSeconds(elapsedTime);
			string currenttimePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
			timeCounter.text = currenttimePlayingStr;
			yield return null;
			//return to this point on the next frame checks the while loop again
		}
	}










}
