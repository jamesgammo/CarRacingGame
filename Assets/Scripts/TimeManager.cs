/*using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
	
	public static TimeManager instance; 
	
	public Text timeCounter; 
	
	public static TimeSpan timePlaying;
	
	private bool timerGoing; 
	
	public static float elapsedTime;
	 
	 
	private void Awake()
	{
		instance = this; //allows to call functions from outside of the class 
	}
	
    // Start is called before the first frame update
    private void Start()
    {
        timeCounter.text = "Time: 00:00.0";
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
		while(timerGoing)
		{
			elapsedTime += Time.deltaTime;
			timePlaying = TimeSpan.FromSeconds(elapsedTime);
			string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
			timeCounter.text = timePlayingStr;
			
			yield return null; 
			//return to this point on the next frame checks the while loop again
		}
	}
}
*/
