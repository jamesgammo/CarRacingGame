using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownControllerTutorial : MonoBehaviour
{
	public int countdownTime;
	public Text countdownDisplay;
	public GameObject tutorialbuttons;

	private void Start()
	{
		StartCoroutine(CountDownToStart());
	}

	IEnumerator CountDownToStart()
	{
		while (countdownTime > 0)
		{
			countdownDisplay.text = countdownTime.ToString();

			yield return new WaitForSeconds(1f);

			countdownTime--;

			if (countdownTime >= 3.5f) { countdownDisplay.color = Color.white; }
			if (countdownTime < 3.5f) { countdownDisplay.color = Color.red; }
		}

		countdownDisplay.text = "GO!";
		yield return new WaitForSeconds(1f);

		//sets active tutorial GUI 
		tutorialbuttons.gameObject.SetActive(true);
		countdownDisplay.gameObject.SetActive(false);
	}
}


