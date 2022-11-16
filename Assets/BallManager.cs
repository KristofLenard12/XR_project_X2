using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject[] ballTransforms;
    private Transform[] ballStartLocations;

    // Start is called before the first frame update
    void Start()
    {
        //get all the ball starting locations
        ballStartLocations = new Transform[ballTransforms.Length];
        for (int i = 0; i < ballTransforms.Length; i++)
        {
            ballStartLocations[i] = ballTransforms[i].transform;
        }
    }

    public void OnResetButtonPress()
    {
        for (int i = 0; i < ballStartLocations.Length; i++)
        {
            ballTransforms[i].transform.position = ballStartLocations[i].position;
        }
    }
}
