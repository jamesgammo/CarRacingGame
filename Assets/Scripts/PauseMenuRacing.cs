using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenuRacing : MonoBehaviour
{
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	public GameObject UserNamePanelUI;
	public GameObject LapsCounter;
	public GameObject TimeDisplay;
	public GameObject BestTimeCounter;
	public GameObject CountDownDisplay;



	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (GameIsPaused)
			{
				Resume();
			}

			else
			{
				Pause();
			}
		}
	}

	public void Resume()
	{
		//elements being disabled 
		pauseMenuUI.SetActive(false);

		Time.timeScale = 1f;
		GameIsPaused = false;
		Debug.Log("Game Resumed");

		//elements being enabled 
		UserNamePanelUI.SetActive(true);
		LapsCounter.SetActive(true);
		TimeDisplay.SetActive(true);
		BestTimeCounter.SetActive(true);
		CountDownDisplay.SetActive(true);
	}

	void Pause()
	{
		// elements being enabled 
		pauseMenuUI.SetActive(true);

		Time.timeScale = 0f;
		GameIsPaused = true;
		Debug.Log("Game Paused");

		// elements being disabled 
		LapsCounter.SetActive(false);
		TimeDisplay.SetActive(false);
		BestTimeCounter.SetActive(false);
		CountDownDisplay.SetActive(false);

	}

	public void LoadMenu()
	{
		Time.timeScale = 1f;
		Debug.Log("Loading Menu...");
		SceneManager.LoadScene("MainMenu");
		PauseMainMenu.panel = 10;
	}

	public void QuitGame()
	{
		Debug.Log("Quitting Game...");
		Application.Quit();
	}

}

