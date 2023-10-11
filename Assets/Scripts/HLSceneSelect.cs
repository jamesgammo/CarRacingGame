using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HLSceneSelect : MonoBehaviour
{
	public void selectScene(){
		switch (this.gameObject.name) {
		case "Tutorial":
			SceneManager.LoadScene ("HL - Tutorial");
			break; 
		case "Explore":
			SceneManager.LoadScene("HL - Explore 1");
			break; 
		case "TimeTrial":
			SceneManager.LoadScene ("HL - TT");
			break;
		}
	}
}
