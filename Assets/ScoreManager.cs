using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public string scoreText;
    public GameObject scoreUI;

    void Score()
    {
        scoreText = "Score: " + score.ToString();
        scoreUI.GetComponent<Text>().text = scoreText;
    }
}
