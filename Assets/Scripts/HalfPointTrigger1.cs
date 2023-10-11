using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger1 : MonoBehaviour 
{
    
	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;
	
	void OnTriggerEnter ()
	{
		LapCompleteTrig.SetActive(true);	
		HalfLapTrig.SetActive(false);
		Debug.Log("Halfway point entered");
	}
}
 