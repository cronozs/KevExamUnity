using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    [SerializeField] private float directionX;
    [SerializeField] private float directionForceX;
    [SerializeField] private float directionZ;
    [SerializeField] private float directionForceZ;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(directionForceX, 0, directionForceZ), ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(directionX, 0, directionZ), ForceMode.Force);
    }
}
