	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownController : MonoBehaviour
{
   public int countdownTime;
   public Text countdownDisplay;
	public GameObject CountDownTimer;

   private void Start()
   {
	   StartCoroutine(CountDownToStart());
   }
   
   IEnumerator CountDownToStart()
   {
	   while(countdownTime > 0)
	   {
		   countdownDisplay.text=countdownTime.ToString();
		   
		   yield return new WaitForSeconds(1f);
		   
			//decreases count down time by one 
		   countdownTime--;
		   
			//changes the text to red
		    if(countdownTime>=3.5f){countdownDisplay.color = Color.white;}
			if(countdownTime<3.5f){countdownDisplay.color = Color.red;}
	   }

	   //starts the timer once the timer has reached GO! 
		countdownDisplay.text = "GO!";
		yield return new WaitForSeconds(1f);
		//countdownDisplay.gameObject.SetActive(false);
		ScoreTimeManager.instance.BeginTimer();
		CountDownTimer.SetActive(false);

	}
}

 
