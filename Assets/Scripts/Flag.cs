using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("GolfBall"))
        {
            GameObject grandpa = transform.parent.parent.gameObject;
            grandpa.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
