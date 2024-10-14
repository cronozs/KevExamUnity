using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalBall : MonoBehaviour
{
    public TextMeshProUGUI tries;

    private void OnTriggerEnter(Collider other)
    {
        int trys = int.Parse(tries.text);
        trys--;
        tries.text = trys.ToString();
        Destroy(other.gameObject);
    }
}
