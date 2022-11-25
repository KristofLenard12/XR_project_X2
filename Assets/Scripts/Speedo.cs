using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Speedo : MonoBehaviour
{
    public float speed;
    public TextMeshPro speedo; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CalcSpeed());
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
        speedo.text = "" + speed;
    }
}
