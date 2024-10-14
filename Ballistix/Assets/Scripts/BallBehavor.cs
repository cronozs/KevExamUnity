using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavor : MonoBehaviour
{
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        _rb.AddForce(new Vector3(0,0, 0.00005f), ForceMode.Force);
        Debug.Log(_rb.velocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rb.AddForce(new Vector3(0,0, 0.00003f), ForceMode.Force);
        Debug.Log("colicion");
    }
}
