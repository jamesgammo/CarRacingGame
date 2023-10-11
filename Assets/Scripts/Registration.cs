/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Registration : MonoBehaviour
{
	public InputField nameField; 
	public InputField passwordField;
	public Button submitButton;
	public void CallRegister()
	{
		//starts coroutine to register user 
		StartCoroutine(Register());
	}
    
	IEnumerator Register()
	{
		
		//creating form and posting this to the surver 
		WWWForm form = new WWWForm();
		form.AddField("name", nameField.text);
		form.AddField("password", passwordField.text);
		
		UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlconnect/register.php",form); 
		//holds the function until rest of data is recieved 
		yield return www.SendWebRequest();
		
		//returns the text of the webpage 
		if (www.downloadHandler.text == "0")
		{
			Debug.Log("User created successfully");
			UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
		}	
		else 
		{
			Debug.Log("User creation failed. Error #" + www.downloadHandler.text);
		}
	}
	
	//forms only accepted under certain conditions and verify the request being made 
	public void VerifyInputs()
	{
		submitButton.interactable = (nameField.text.Length >=8 && passwordField.text.Length >= 8 );
	}
	
}
*/	