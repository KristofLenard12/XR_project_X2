using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartBoardScript : MonoBehaviour
{

    private float _times2Beginning = 0.2524f;
    private float _times2Ending = 0.27227f;
    private float _times3Beginning = 0.3724f;
    private float _times3Ending = 0.39f;
    private List<AnglePoints> angles = new List<AnglePoints>();

    // Start is called before the first frame update
    void Start()
    {
        float leftAngle = 0;
        float rightAngle = 17.9999f;
        for(int i = 0; i < 20; i++)
        {
            angles.Add(new AnglePoints(leftAngle, rightAngle, getPoints(i)));
            leftAngle += 18f;
            rightAngle += 18f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Dart")
        {
            Vector3 impact = collision.transform.position;
            GameObject dart = collision.gameObject;
            Rigidbody body = dart.GetComponent<Rigidbody>();
            body.useGravity = false;

            float angle = CalculateAngel(impact.x, impact.y);
            float distance = CalculateDistance(impact.x, impact.y);
            Debug.Log(CalculatePoints(angle, distance));
        }
    }

    private float CalculateDistance(float x, float y)
    {
        return Mathf.Sqrt(Mathf.Pow((x), 2) + Mathf.Pow(y, 2));
    }

    private float CalculateAngel(float x, float y)
    {
        float times = (0.0688f * x) + (0.3891f * y);
        float a = Mathf.Sqrt(Mathf.Pow(0.0688f, 2) + Mathf.Pow(0.3891f, 2));
        float b = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));
        return (180 / Mathf.PI) * Mathf.Acos(times / a * b);
    }

    private int CalculatePoints(float angle, float distance)
    {
        int multiplier = 1;
        if (distance >= _times2Beginning && distance <= _times2Ending) multiplier = 2;
        else if (distance >= _times3Beginning && distance <= _times3Beginning) multiplier = 3;

        foreach (AnglePoints pointAngle in angles)
        {
            if(pointAngle.IsWithin(angle)) return pointAngle.anglePoints * multiplier;
        }
        return 0;
    }

    private class AnglePoints
    {
        public AnglePoints(float left, float right, int anglePonts)
        {
            leftBoundry = left;
            rightBoundry = right;
        }

        public float leftBoundry { get; private set; }
        public float rightBoundry { get; private set; }
        public int anglePoints { get; private set; }

        public bool IsWithin(float angle)
        {
            return leftBoundry <= angle && rightBoundry >= angle;
        }
    }

    private int getPoints(int i)
    {
        switch (i)
        {
            case 0:
                return 20;
            case 1:
                return 1;
            case 2:
                return 18;
            case 3:
                return 4;
            case 4:
                return 13;
            case 5:
                return 6;
            case 6:
                return 10;
            case 7:
                return 15;
            case 8:
                return 2;
            case 9:
                return 17;
            case 10:
                return 3;
            case 11:
                return 19;
            case 12:
                return 7;
            case 13:
                return 16;
            case 14:
                return 8;
            case 15:
                return 11;
            case 16:
                return 14;
            case 17:
                return 9;
            case 18:
                return 12;
            case 19:
                return 5;
            default:
                return -1;
        }
    }
}
