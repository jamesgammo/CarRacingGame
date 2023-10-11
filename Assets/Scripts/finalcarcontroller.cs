using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalcarcontroller : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    //values for the input keyboard 
    private float horizontalInput;
    private float verticalInput;
    private float currentSteeringAngle;
    private float currentBreakingForce;
    private bool isBreaking;

    //[SerializeField] private float motorforce, brakeForce, maxSteerAngle;
    [SerializeField] private float brakeForce, motorforce, maxSteerAngle;
    [SerializeField] private WheelCollider frontLeftWheelCollider, frontRightWheelCollider, backLeftWheelCollider, backRightWheelCollider;
    [SerializeField] private Transform frontLeftWheelTransform, frontRightWheelTransform, backLeftWheelTransform, backRightWheelTransform;


    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        isBreaking = Input.GetKey(KeyCode.Space);

    }

    private void FixedUpdate()
    {
        //calling all subroutines
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();

    }

    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = verticalInput * motorforce;
        frontRightWheelCollider.motorTorque = verticalInput * motorforce;

        currentBreakingForce = isBreaking ? brakeForce : 0f;

        ApplyBreaking();
    }


    private void ApplyBreaking()
    {
        //applying breaking force 
        frontLeftWheelCollider.brakeTorque = currentBreakingForce;
        frontRightWheelCollider.brakeTorque = currentBreakingForce;
        backLeftWheelCollider.brakeTorque = currentBreakingForce;
        backRightWheelCollider.brakeTorque = currentBreakingForce;
    }

    private void HandleSteering()
    {
        frontLeftWheelCollider.steerAngle = 30 * horizontalInput;
        frontRightWheelCollider.steerAngle = 30 * horizontalInput;
    }    
        
    private void UpdateWheels()
    {
        //updating the wheel positions
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(backLeftWheelCollider, backLeftWheelTransform);
        UpdateSingleWheel(backRightWheelCollider, backRightWheelTransform);
        
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Quaternion rot;
        Vector3 pos;

        wheelCollider.GetWorldPose(out pos,out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}

