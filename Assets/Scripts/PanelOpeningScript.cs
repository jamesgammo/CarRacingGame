using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpeningScript : MonoBehaviour
{
	public GameObject TutorialPanel; 
	public GameObject MapPanel; 
	public GameObject GamePanel; 
	
	public void OpenTurorialPanel()
	{
		if (TutorialPanel != null)
		{
			bool isActive = TutorialPanel.activeSelf;
			TutorialPanel.SetActive(!isActive);
			Debug.Log("Opening Tutorial Panel...");
		}
	}

	public void OpenGamePanel()
	{
		if (GamePanel != null)
		{
			bool isActive = GamePanel.activeSelf;
			GamePanel.SetActive(!isActive);
			Debug.Log("Opening Game Panel...");
		}
	}


	public void OpenMapPanel()
	{
		if (MapPanel != null)
		{
			bool isActive = MapPanel.activeSelf;
			MapPanel.SetActive(!isActive);
			Debug.Log("Opening Map Panel...");
		}
	}
}
