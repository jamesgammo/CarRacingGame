using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
	public static bool GameIsPaused = false;

	// pause menu which will be activated / deactivated 
	public GameObject pauseMenuUI;

	// Updates every second, activating once ESC is pressed 
	// decides wether to activate the pause Menu or deactivate the pause menu e
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

	// resumes the game 
	public void Resume()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		// testing with debug.log statement to check wether subroutine is called 
		Debug.Log("Game Resumed");
	}


	// pauses the game 
	void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
		Debug.Log("Game Paused");
	}

}
