using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioClip> clipList = new List<AudioClip>();
    private Queue<AudioClip> Clips;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        Clips = new Queue<AudioClip>();
        StartAudio();

    }

    public void StartAudio()
    {
        Clips.Clear();
        foreach (AudioClip clip in clipList)
        {
            Clips.Enqueue(clip);

        }
        //NextClip();
    }

    public void NextClip()
    {
        Debug.Log("Queued next clip");
        if(Clips.Count == 0)
        {
            EndAudio();
            return;
        }

        audioClip = Clips.Dequeue();

    }

    void EndAudio()
    {
        Debug.Log("No more clips");
        audioClip = null;
    }

}