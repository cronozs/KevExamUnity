using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _speed = 5;
    [SerializeField] GameObject power;

    void Update()
    {
        if(Input.GetButton("Horizontal") == true)
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * _speed * Time.deltaTime;
        }
        if(Input.GetButtonDown("Jump") == true)
        {
            power.SetActive(true);
            StartCoroutine(DesapperPower());
        }
    }


    IEnumerator DesapperPower()
    {
        yield return new WaitForSeconds(0.3f);
        power.SetActive(false);
    }
}
