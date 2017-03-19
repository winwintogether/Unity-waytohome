using UnityEngine;
using System.Collections;

public class Wheel : MonoBehaviour
{
    public WheelCollider wheelCollider;


    void FixedUpdate()
    {
        Vector3 position;
        Quaternion rotation;

		wheelCollider.GetWorldPose(out position, out rotation);

		transform.position = position;
		transform.rotation = rotation;
    }
}
