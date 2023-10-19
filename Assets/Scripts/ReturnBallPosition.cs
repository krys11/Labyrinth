using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnBallPosition : MonoBehaviour
{
    public Transform myTargetPosition;

    public BallEnemi BallEnemi;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            BallEnemi.targetPoint = myTargetPosition;
        }
    }
}
