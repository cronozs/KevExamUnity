using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Vector3 minRange;
    [SerializeField] private Vector3 maxRange;
    private Vector3 _targetPosition;
    private float _speed = 3;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += _targetPosition * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 position = other.gameObject.transform.position;
        Vector3 velocity = other.GetComponent<Rigidbody>().velocity;
        Vector3 centerRange = (minRange + maxRange) / 2;
        Vector3 direction = (centerRange - position).normalized;
        if (Vector3.Dot(velocity.normalized, direction) > 0)
        {
            float distanceToRange = Vector3.Distance(position, centerRange);
            Debug.Log(WillEnterRange(position, velocity));
        }
    }

    private bool WillEnterRange(Vector3 position, Vector3 velocity)
    {
        Vector3 predictedPosition = position + velocity * Time.deltaTime;
        _targetPosition = predictedPosition;
        Debug.Log(predictedPosition);
        return predictedPosition.x >= minRange.x && predictedPosition.x <= maxRange.x &&
               predictedPosition.y >= minRange.y && predictedPosition.y <= maxRange.y &&
               predictedPosition.z >= minRange.z && predictedPosition.z <= maxRange.z;
    }
}
