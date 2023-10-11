using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapScript : MonoBehaviour
{

	public Transform player;

	//update end of every second 
	void LateUpdate()
	{
		//vector3 = car position 
		Vector3 newPosition = player.position;
		// causes the y position to stay the same so camera does not move up and down 
		newPosition.y = transform.position.y;
		transform.position = newPosition;

		transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
	}

}