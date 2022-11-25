using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class SimpleCarController : MonoBehaviour
{
    public List<AxleInfo> axleInfos; // the information about each individual axle
    public float maxMotorTorque; // maximum torque the motor can apply to wheel
    public float maxSteeringAngle; // maximum steer angle the wheel can have
    public float acceleration;
    public float brakes;
    public TextMeshPro speedo;
    public GameObject resetButton;
    public TextMeshPro handbrake;

    private int speed;
    private bool handbrakeSet; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CalcSpeed());
        resetButton.SetActive(false);

    }

    public void FixedUpdate()
    {
        float steering = maxSteeringAngle * OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x;
        float motor = 0; 
        if(OVRInput.Get(OVRInput.Button.One)){
            motor = maxMotorTorque * 1 * acceleration;
        }

        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor)
            {
                if(OVRInput.Get(OVRInput.Button.One) && !handbrakeSet)
                {
                    axleInfo.leftWheel.motorTorque = motor;
                    axleInfo.rightWheel.motorTorque = motor;
                }else{
                    axleInfo.leftWheel.motorTorque = 0;
                    axleInfo.rightWheel.motorTorque = 0;
                }
            }
            if(axleInfo.bracking)
            {
                if(speed > 0 && OVRInput.Get(OVRInput.Button.Two) && !handbrakeSet)
                {
                    axleInfo.leftWheel.motorTorque = motor - brakes * 9;
                    axleInfo.rightWheel.motorTorque = motor - brakes * 9;
                }
                else if(OVRInput.Get(OVRInput.Button.Two) && !handbrakeSet)
                {
                    axleInfo.leftWheel.motorTorque = -100;
                    axleInfo.rightWheel.motorTorque = -100;
                }
            }
        }

        if(OVRInput.Get(OVRInput.RawButton.LIndexTrigger) && speed == 0 && !handbrakeSet){
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition; 
            handbrakeSet = true; 
            handbrake.SetText("Handbrake Set");
        }else if(OVRInput.Get(OVRInput.RawButton.LIndexTrigger)  && handbrakeSet){
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            handbrakeSet = false; 
            handbrake.SetText("");
        }
    }

    public void ResetCar()
    {
        gameObject.transform.position = new Vector3(-45.3f, 0, -21.2f);
        resetButton.SetActive(false);
    }

    IEnumerator CalcSpeed()
    {
        bool isPlaying = true;

        while (isPlaying)
        {
            Vector3 prevPos = transform.position;

            yield return new WaitForFixedUpdate();

            speed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime) * 2;
        }
    }

    private void Update()
    {
        speedo.text = "Speed: " + speed;
        if(gameObject.transform.rotation.z > 0.50f || gameObject.transform.rotation.z < -0.50f)
        {
            resetButton.SetActive(true);
        }
    }
}

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // is this wheel attached to motor?
    public bool steering; // does this wheel apply steer angle?
    public bool bracking;
}
