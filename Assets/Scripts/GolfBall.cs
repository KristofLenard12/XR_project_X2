using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfBall : MonoBehaviour
{
    [SerializeField]
     private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GolfClub"))
        {
            rb.AddForce(10,10,10, ForceMode.Force);
        }

    }
}
