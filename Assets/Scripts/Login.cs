using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Login : MonoBehaviour
{
	public InputField nameField; 
	public InputField passwordField;
	public Button submitButton;
	public GameObject GameMaps;
	public GameObject LoginScreen;
	public Text Output;
	


	public void CallLogin()
	{
		//starts coroutine to register user 
		StartCoroutine(LoginPlayer());
	}
	IEnumerator LoginPlayer()
	{
		WWWForm form = new WWWForm();
		form.AddField("username", nameField.text);
		form.AddField("password", passwordField.text);
		WWW www = new WWW("http://localhost/sqlconnect/login.php",form); 
		//holds the function until rest of data is recieved 
		yield return www;
	
		if (www.text[0] == '0')	
		{
			DBManager.username = nameField.text;
			DBManager.score = int.Parse(www.text.Split('\t')[1]);	
			Debug.Log("Logged in");
			GameMaps.SetActive(true);
			LoginScreen.SetActive(false);
		}
		else 
		{
			Debug.Log("User login failed. Error #" + www.text);
			Output.GetComponent<Text>().text = "User creation failed. Error#" + www.text;
		}
	}
	public void VerifyInputs()
	{
		submitButton.interactable = (nameField.text.Length >=3 && passwordField.text.Length >= 5 );
	}
}
