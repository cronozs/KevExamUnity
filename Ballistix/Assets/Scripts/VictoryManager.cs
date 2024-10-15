using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VictoryManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerLife;
    [SerializeField] private Image playerImage;
    [SerializeField] private TextMeshProUGUI leftEnemylife;
    [SerializeField] private Image leftEnemyImage;
    [SerializeField] private TextMeshProUGUI rightEnemyLife;
    [SerializeField] private Image RightEnemyImage;
    [SerializeField] private TextMeshProUGUI upEnemyLife;
    [SerializeField] private Image upEnemyImage;

    [SerializeField] private Canvas canvasWin;
    [SerializeField] private Canvas canvasGame;
    [SerializeField] private Image WinImage;
    [SerializeField] private TextMeshProUGUI nameWinner;


    void Start()
    {
        
    }

    void Update()
    {
        if(int.Parse(playerLife.text) <= 0 && int.Parse(leftEnemylife.text) <= 0 && int.Parse(rightEnemyLife.text) <= 0)
        {
            //up enemy win
            nameWinner.text = "Up Enemy";
            WinImage.color = upEnemyImage.color;
            canvasWin.enabled = true;
            canvasGame.enabled = false;
            Debug.Log("Up");
            Time.timeScale = 0;
        }
        else if(int.Parse(playerLife.text) <= 0 && int.Parse(leftEnemylife.text) <= 0 && int.Parse(upEnemyLife.text) <= 0)
        {
            //right enemy Win
            nameWinner.text = "Right Enemy";
            WinImage.color = RightEnemyImage.color;
            canvasWin.enabled = true;
            canvasGame.enabled = false;
            Debug.Log("Right");
            Time.timeScale = 0;
        }
        else if (int.Parse(playerLife.text) <= 0 && int.Parse(rightEnemyLife.text) <= 0 && int.Parse(upEnemyLife.text) <= 0)
        {
            //left Enemy Win
            nameWinner.text = "Left Enemy";
            WinImage.color = leftEnemyImage.color;
            canvasWin.enabled = true;
            canvasGame.enabled = false;
            Debug.Log("Left");
            Time.timeScale = 0;
        }
        else if (int.Parse(upEnemyLife.text) <= 0 && int.Parse(leftEnemylife.text) <= 0 && int.Parse(upEnemyLife.text) <= 0)
        {
            //Player Win
            nameWinner.text = "Player";
            WinImage.color = playerImage.color;
            canvasWin.enabled = true;
            canvasGame.enabled = false;
            Debug.Log("PLayer");
            Time.timeScale = 0;
        }
    }
}
