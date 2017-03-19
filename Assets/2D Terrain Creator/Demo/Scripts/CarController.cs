using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour
{
    public Vector3 centerOfMass = Vector3.zero;

    public WheelCollider backLeftWheel;
    public WheelCollider backRightWheel;

    public float speed = 100;

    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass;
    }

    void FixedUpdate()
    {
        float motorForce = Input.GetAxis("Vertical") * speed;

        backLeftWheel.motorTorque = motorForce;
        backRightWheel.motorTorque = motorForce;
    }
}
