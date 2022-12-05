using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public List<GameObject> gridList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
       
        int randomIndex = Random.Range(0, gridList.Count);
        scoreText.text = "Score : 0";
        

    }

    void update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }     
        
    }
   

    // Update is called once per frame
    public void Score()
    {
        score = score + 10;
        scoreText.text = "Score: " + score.ToString();
        
    }
}
