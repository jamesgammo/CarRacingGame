using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuTutorial2 : MonoBehaviour
{
	public static bool GameIsPaused = false;
	public GameObject tutorialCanvas;
	public GameObject pauseMenuUI;


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
		// elements being disabled 
		pauseMenuUI.SetActive(false);

		Time.timeScale = 1f;
		GameIsPaused = false;
		Debug.Log("Game Resumed");

		// elements being enabled 
		tutorialCanvas.SetActive(true);

	}

	void Pause()
	{
		// elements being enabled 
		pauseMenuUI.SetActive(true);

		Time.timeScale = 0f;
		GameIsPaused = true;
		Debug.Log("Game Paused");

		//elements being disabled 
		tutorialCanvas.SetActive(false);
	}

	public void LoadMenu()
	{
		Time.timeScale = 1f;
		Debug.Log("Loading Menu...");
		SceneManager.LoadScene("MainMenu");
	}

	public void QuitGame()
	{
		Debug.Log("Quitting Game...");
		Application.Quit();
	}

}