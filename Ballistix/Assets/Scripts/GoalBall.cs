using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalBall : MonoBehaviour
{
    public TextMeshProUGUI tries;
    [SerializeField] private GameObject EndObstacle;
    [SerializeField] private GameObject taget;
    private void OnTriggerEnter(Collider other)
    {
        int trys = int.Parse(tries.text);
        trys--;
        if(trys == 0)
        {
            EndObstacle.SetActive(true);
            Destroy(taget);
        }
        tries.text = trys.ToString();
        Destroy(other.gameObject);
    }
}
