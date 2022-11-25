using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfClubFollower : MonoBehaviour
{
    private GolfClubCollider _golfClubCollider;
    private Rigidbody _rigidbody;
    private Vector3 _velocity;

    [SerializeField]
    private float _sensitivity = 100f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 destination = _golfClubCollider.transform.position;
        _rigidbody.transform.rotation = transform.rotation;

        _velocity = (destination - _rigidbody.transform.position) * _sensitivity;

        _rigidbody.velocity = _velocity;
        transform.rotation = _golfClubCollider.transform.rotation;
    }

    public void SetFollowTarget(GolfClubCollider batFollower)
    {
        _golfClubCollider = batFollower;
    }
}
