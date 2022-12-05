using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public int rand;
    public int limit;
    public float delay;
    
    public GameObject[] SpawnPoints;
    public GameObject spawnPoint;
    public GameObject AudioManager;
    public AudioSource playerAudioSource;
    // Start is called before the first frame update

    private void Start()
    {
        delay = 5f;
        //limit = SpawnPoints.Length;
        limit = 18;
        StartCoroutine("SpawnTokens");
        AudioManager = GameObject.Find("AudioManager");
       limit = AudioManager.GetComponent<AudioManager>().clipList.Count;
        playerAudioSource = GameObject.Find("Camera").GetComponent<AudioSource>();
    }
    


     IEnumerator SpawnTokens()
    {
        while(limit > 0)
        {
            rand = UnityEngine.Random.Range(0, SpawnPoints.Length);
            //Debug.Log("SpawnTokens");

            spawnPoint = SpawnPoints[rand];
            //spawnPoint.transform.GetChild(0).GetComponent<portalScript>().Anim();
                    if(spawnPoint.GetComponent<TokenScript>().ready == true)
                    {
                        spawnPoint.transform.GetComponentInChildren<portalScript>().Anim();
                        spawnPoint.GetComponent<TokenScript>().SpawnToken();
                     
                        limit--;
                        delay = delay - (delay / 15);
                        
                        yield return new WaitForSeconds(delay);
                    }
                    else
                    {
                        yield return null;
                    }
                    
                    if(!playerAudioSource.isPlaying)
                      {
                         Time.timeScale = 0;
                      }

        }
    }

   
}

