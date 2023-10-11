using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointsSystems : MonoBehaviour
{
	public GameObject CheckpointEnter;

	void OnTriggerEnter()
	{
		CheckpointEnter.SetActive(false);
		Debug.Log("Checkpoint Entered");
	}
}

