using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatDriver : MonoBehaviour
{

    public float thrustSpeed = 0;
    public float rotationSpeed = 0;
    public Transform boat;
    public GameObject steeringWheel;
    public Transform thrustLever;

    public float maxSpeed;



    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        getRotation();
        getThrust();

        boat.Rotate(new Vector3(0, rotationSpeed, 0));
        boat.Translate(Vector3.left * Time.deltaTime * thrustSpeed);
    }

    private void getRotation()
    {
        var turnAngle = steeringWheel.GetComponent<SteeringWheelController>().outputAngle;

        if (turnAngle > 20)
            rotationSpeed = 0.5f;
        if (turnAngle < -20)
            rotationSpeed = -0.5f;
        if (turnAngle < 20 && turnAngle > -20)
            rotationSpeed = 0;
    }

    private void getThrust()
    {

        thrustSpeed = -thrustLever.transform.localRotation.x * 10;
    }
}
