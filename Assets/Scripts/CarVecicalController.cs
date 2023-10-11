using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarVecicalController : MonoBehaviour
{
    [System.Serializable]
    public class Axleinfo{
        public WheelCollider leftWheel;
        public WheelCollider rightWheel;

        public bool motor;
        public bool steering;
    }

    public List<Axleinfo> AxleInfos = new List<Axleinfo>();
    public float maxMotorTorque;
    public float maxSteeringAngles;
     
    public void ApplyLocalPositionToVisual( WheelCollider collider)
    {
        if(collider.transform.childCount == 0)
        {
            return;
        }
        Transform visualWheel = collider.transform.GetChild(0);

        Vector3 position;
        Quaternion rotation;


        collider.GetWorldPose(out position, out rotation);

        visualWheel.transform.position = position;
        visualWheel.transform.rotation = rotation;
    }

    // Update is called once per frame
    
    private void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngles * Input.GetAxis("Horizontal");

        foreach(Axleinfo axleinfo in AxleInfos)
        {
            if (axleinfo.steering == true)
            {
                axleinfo.leftWheel.steerAngle = steering;
                axleinfo.rightWheel.steerAngle = steering;
            }
            if(axleinfo.motor == true)
            {
                axleinfo.leftWheel.motorTorque = motor;
                axleinfo.rightWheel.motorTorque = motor;
            }

            ApplyLocalPositionToVisual(axleinfo.leftWheel);
            ApplyLocalPositionToVisual(axleinfo.rightWheel);

        }
    }
}
