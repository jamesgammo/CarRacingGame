using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
   
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	public GameObject UserNamePanelUI;
	public GameObject LapLabelUI;
	public GameObject BestTimePanel;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (GameIsPaused)
			{
			Resume();
			} else
			{
				Pause();
			}
		}
    }
	
	public void Resume ()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		Debug.Log("Game Resumed");
		LapLabelUI.SetActive(true);
		UserNamePanelUI.SetActive(true);
		BestTimePanel.SetActive(true);
	}
	
	void Pause ()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
		Debug.Log("Game Paused");
		UserNamePanelUI.SetActive(false);
		LapLabelUI.SetActive(false);
		BestTimePanel.SetActive(false);

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
