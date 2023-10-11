using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebTesting : MonoBehaviour {


    IEnumerator Start()
	{
		WWW request = new WWW("http://localhost/sqlconnect/WebTesting.php"); //fetches code from php file 
        yield return request; //obtains code from php file 
		string[] webResults = request.text.Split('\t');//inputs teh data in an array called webResults and splits text by paraphrasing 
		Debug.Log(webResults[0]);
		int webNumber = int.Parse(webResults[1]);
		webNumber *=2; 
		Debug.Log(webNumber);
		
	}
	
}

        
       