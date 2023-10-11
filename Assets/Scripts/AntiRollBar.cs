using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiRollBar : MonoBehaviour
{
	//wheel colliders 
	public WheelCollider backWheelLeftCollider;
	public WheelCollider backWheelRightCollider;


	//antiroll force
	public float AntiRoll = 5000.0f;

	private Rigidbody Player;

	void Start()
	{
		//rigidbody from the player
		Player = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		WheelHit hit;
		float travelL = 1.0f;
		float travelR = 1.0f;
		
		//checking if left wheel is grouned 
		bool groundedL = backWheelLeftCollider.GetGroundHit(out hit);
		if (groundedL)
		{
			//applying the transform change from the wheel collider - the radius to get the difference

			travelL = (-backWheelLeftCollider.transform.InverseTransformPoint(hit.point).y - backWheelLeftCollider.radius) / backWheelLeftCollider.suspensionDistance;
		}

		//checking if right wheel is grouned 
		bool groundedR = backWheelRightCollider.GetGroundHit(out hit);
		if (groundedR)
		{
			travelR = (-backWheelRightCollider.transform.InverseTransformPoint(hit.point).y - backWheelRightCollider.radius) / backWheelRightCollider.suspensionDistance;
		}

		//applying anti-roll to the difference in the wheel distance
		float antiRollForce = (travelL - travelR) * AntiRoll;

		if (groundedL)
			Player.AddForceAtPosition(backWheelLeftCollider.transform.up * -antiRollForce, backWheelLeftCollider.transform.position);

		if (groundedR)
			Player.AddForceAtPosition(backWheelRightCollider.transform.up * antiRollForce, backWheelRightCollider.transform.position);
	}
}