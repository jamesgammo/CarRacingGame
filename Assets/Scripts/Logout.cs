using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logout : MonoBehaviour
{
	public static void LogOut() //username changed to null to log out
	{
		DBManager.username = null;
		Debug.Log("User Logged out");
	}
}
