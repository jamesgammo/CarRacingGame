using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;



public class RegistrationSQL : MonoBehaviour
{
	public InputField nameField; 
	public InputField passwordField;
	public Button submitButton;
	public GameObject GameMaps;
	public GameObject Registration;
	public Text Output;


	public void CallRegisterSQL()
	{
		StartCoroutine(Register());
	}

	IEnumerator Register()
	{
		//creating form and posting this to the surver 
		WWWForm form = new WWWForm();
		//takes inputs from the text fields username and password 
		form.AddField("username", nameField.text);
		form.AddField("password", passwordField.text);
		WWW www = new WWW("http://localhost/sqlconnect/register.php",form); 
		//holds the function until rest of data is recieved 
		yield return www;		
		//if everything in the php script
		if (www.text == "0")
		{
			DBManager.username = nameField.text;
			Debug.Log("User created successfully");
			Output.GetComponent<Text>().text = "User created successfully";
			GameMaps.SetActive(true);
			Registration.SetActive(false);
		}	
		else 
		{
			//Adding text so the user can read more clearly 
			Output.GetComponent<Text>().text = "User creation failed. Error #" + www.text;
			Debug.Log("User creation failed. Error #" + www.text);
		}
	}
	
	//verifying inputs from the text fields called by the register button 
	public void VerifyInputs()
	{
		submitButton.interactable = (nameField.text.Length >=3 && passwordField.text.Length >= 5);
	}
	
}
