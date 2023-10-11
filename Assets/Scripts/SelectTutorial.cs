using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectTutorial : MonoBehaviour
{
    public void selectScene(){
	    switch (this.gameObject.name){
		case"Tutorial":
			SceneManager.LoadScene("DT - Tutorial");
			break;
		case"Time Trial":
			SceneManager.LoadScene("DT");
				Debug.Log("Calling time trial map");
			break; 
		case"Explore":
			SceneManager.LoadScene("DT - Explore");
				Debug.Log("Calling time Explore map");
				break;
	    }
    }
}
