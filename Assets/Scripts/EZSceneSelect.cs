using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EZSceneSelect : MonoBehaviour
{
	public void selectScene(){
		switch (this.gameObject.name) {
		case "Tutorial":
			SceneManager.LoadScene("EZ - tutorial");
			break;
		case "Explore":
			SceneManager.LoadScene("EZ - Explore");
			break; 
		case "Time Trial":
			SceneManager.LoadScene("EZ - TimeTrial");
			break;
		}
	}
}
