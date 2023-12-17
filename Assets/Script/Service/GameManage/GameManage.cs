using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManage : MonoBehaviour ,IGameManage
{
    private int score;
    public TextMeshProUGUI scoreText;
    
    public void OnNotify()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
