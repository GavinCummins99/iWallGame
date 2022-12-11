using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestureTrigger : MonoBehaviour
{
    public GameObject child;
    public GameObject scoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void GestureDetected()
    {
       if(transform.childCount > 0)
        {
            child = this.transform.GetChild(0).transform.gameObject;
            child.GetComponent<dissolveScript>().TokenTrigger();
        }

       if(scoreBoard.activeSelf == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        }
    }
}
