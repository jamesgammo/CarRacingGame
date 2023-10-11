using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DTSceneSelect : MonoBehaviour
{
	public void selectScene(){
		switch (this.gameObject.name){
		case"Tutorial":
			SceneManager.LoadScene ("DT - Tutorial");
			break; 
		case"Time Trial":
			SceneManager.LoadScene ("DT");
			break; 
		case"Free Play":
			SceneManager.LoadScene ("DT - Explore");
			break;
		}
	}
}
