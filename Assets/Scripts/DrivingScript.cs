using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingScript : MonoBehaviour
{
    [SerializeField]
    public WheelCollider _WCLeftFront;
    [SerializeField]
    public WheelCollider _WCRightFront;
    [SerializeField]
    public WheelCollider _WCLeftBack;
    [SerializeField]
    public WheelCollider _WCRightBack;


    [SerializeField]
    public Transform _WheelLeftFront;
    [SerializeField]
    public Transform _WheelRightFront;
    [SerializeField]
    public Transform _WheelLeftBack;
    [SerializeField]
    public Transform _WheelRightBack;


    public float motorTorque = 100f;
    public float maxSteet = 20f;

    private void FixedUpdate()
    {
        //_WCLeftBack.motorTorque = motorTorque * 5;
        //_WCRightBack.motorTorque = motorTorque * 5;
    }
}
