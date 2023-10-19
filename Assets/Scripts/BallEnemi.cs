using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEnemi : MonoBehaviour
{
    public float vitesse;
    public Transform targetPoint;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, vitesse * Time.deltaTime );
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject.Find("Capsule").GetComponent<PlayerControler>().Death();
        }
    }
}
