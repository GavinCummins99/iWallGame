using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    AudioSource myAudioSource;
    public GameObject audioManager;


    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        audioManager = GameObject.Find("AudioManager");
        
    }

    // Update is called once per frame
    public void NextClip()
    {
        myAudioSource.clip = audioManager.GetComponent<AudioManager>().audioClip;
        myAudioSource.Play();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            audioManager.GetComponent<AudioManager>().NextClip();
            NextClip();
        }
    }
}
