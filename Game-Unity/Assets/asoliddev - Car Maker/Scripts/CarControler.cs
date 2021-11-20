using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Car Controls
/// </summary>
public class CarControler : MonoBehaviour
{
    /// <summary>
    /// List of the wheel settings of the car.
    /// </summary>
    public List<WheelAxle> wheelAxleList;

    /// <summary>
    /// Car settings of the car.
    /// </summary>
    public CarSettings carSettings;
  
    /// <summary>
    /// Rigidbody of the car.
    /// </summary>
    private Rigidbody rbody;

    /// <summary>
    /// Calculated speed of the car.
    /// </summary>
    public float speed = 0;

    private void Start()
    {
        ///create rigidbody
        rbody = this.GetComponent<Rigidbody>();

        ///set mass of the car
        rbody.mass = carSettings.mass;

        ///set drag of the car
        rbody.drag = carSettings.drag;

        //set the center of mass of the car
        rbody.centerOfMass = carSettings.centerOfMass;
    }

    public void FixedUpdate()
    {
        ///get speed of the car
        speed = rbody.velocity.magnitude;

        ///calculate motor torque
        float motor = carSettings.motorTorque * Input.GetAxis("Vertical");
        
        //calculate wheel steering
        float steering = carSettings.steeringAngle * Input.GetAxis("Horizontal");

        ///calculate motor break
        float handBrake = Input.GetKey(KeyCode.Space) == true ? carSettings.motorTorque * 1 : 0;
        
        ///iterate all wheel axles
        foreach (WheelAxle wheelAxle in wheelAxleList)
        {

            ///this is a steering axle
            if (wheelAxle.steering)
            {
                ///apply steering
                wheelAxle.wheelColliderLeft.steerAngle = steering;
                wheelAxle.wheelColliderRight.steerAngle = steering;
            }

            ///this is motor axle
            if (wheelAxle.motor)
            {
                ///apply motor torque
                wheelAxle.wheelColliderLeft.motorTorque = motor;
                wheelAxle.wheelColliderRight.motorTorque = motor;
            }

            ///apply motor break
            wheelAxle.wheelColliderLeft.brakeTorque = handBrake;
            wheelAxle.wheelColliderRight.brakeTorque = handBrake;
        }
    }
}