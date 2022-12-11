using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreboardScript : MonoBehaviour
{
    public GameObject scoreboard;   
    public GameObject ItemScores;
    public GameObject PointScore;

   

    private void Update()
    {
        ItemScores.GetComponentInChildren<Text>().text = GetComponent<GameManager>().objectCount.ToString();
        PointScore.GetComponentInChildren<Text>().text = GetComponent<GameManager>().score.ToString();
        if(Time.timeScale == 0)
        {
            scoreboard.SetActive(true);
        }

        if(scoreboard.activeSelf)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);

            }
        }
        
    }

}
