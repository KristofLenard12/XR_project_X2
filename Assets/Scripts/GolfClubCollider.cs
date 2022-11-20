using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfClubCollider : MonoBehaviour
{
    [SerializeField]
    private GolfClubFollower _golfClubFollower;

    private void SpawnBatCapsuleFollower()
    {
        var follower = Instantiate(_golfClubFollower);
        follower.transform.position = transform.position;
        follower.SetFollowTarget(this);
    }

    private void Start()
    {
        SpawnBatCapsuleFollower();
    }
}
