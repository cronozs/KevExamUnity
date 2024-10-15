using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Vector3 minRange;
    [SerializeField] private Vector3 maxRange;
    [SerializeField] private GameObject power;
    private Vector3 _targetPosition;
    private float _speed = 3;
    void Start()
    {
        _targetPosition = transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 position = other.gameObject.transform.position;
        Vector3 velocity = other.GetComponent<Rigidbody>().velocity.normalized;
        WillCrossLine(position, velocity, minRange, maxRange);
        power.SetActive(true);
        StartCoroutine(DesapperPower());
    }

    public void WillCrossLine(Vector3 objPos, Vector3 velocity, Vector3 initPoint, Vector3 endPoint)
    {
        Vector3 intersection;
        Vector3 lineDirection = endPoint - initPoint;
        Vector3 lineNormal = Vector3.Cross(lineDirection, Vector3.up);
        float lineDirecction = Vector3.Dot((initPoint - objPos), lineNormal) / Vector3.Dot(velocity, lineNormal);
        Vector3 futurePosition = objPos + lineDirecction * velocity;

        if (futurePosition.x >= Mathf.Min(initPoint.x, endPoint.x) && futurePosition.x <= Mathf.Max(initPoint.x, endPoint.x))
        {
            intersection = futurePosition;
            _targetPosition = new Vector3(intersection.x,0.5f, intersection.z);
        }
    }

    IEnumerator DesapperPower()
    {
        yield return new WaitForSeconds(0.3f);
        power.SetActive(false);
    }
}
