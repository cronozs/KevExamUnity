using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnPositions;
    [SerializeField] private GameObject ball;

    void Start()
    {
        StartCoroutine(DelaySpawn());
    }


    IEnumerator DelaySpawn()
    {
        yield return new WaitForSeconds(Random.Range(2, 5));
        int selector = Random.Range(0, 4);
        GameObject cuurentBall =  Instantiate(ball, spawnPositions[selector].transform.position, spawnPositions[selector].transform.rotation);
        Rigidbody rb = cuurentBall.GetComponent<Rigidbody>();
        switch(selector)
        {
            case 0:
                rb.AddForce(new Vector3(0.00003f, 0, 0.00003f), ForceMode.Force);
                break;
            case 1:
                rb.AddForce(new Vector3(-0.00003f, 0, 0.00003f), ForceMode.Force);
                break;
            case 2:
                rb.AddForce(new Vector3(0.00003f, 0, -0.00003f), ForceMode.Force);
                break;
            case 3:
                rb.AddForce(new Vector3(-0.00003f, 0, -0.00003f), ForceMode.Force);
                break;
            default:
                break;
        }
        StartCoroutine(DelaySpawn());
    }
}
