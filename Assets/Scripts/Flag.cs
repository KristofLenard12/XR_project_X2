using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private GameObject flag;
    void Start()
    {
        flag = GameObject.Find("Flag");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GolfBall"))
        {
            flag.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
