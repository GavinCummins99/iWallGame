using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class dissolveScript : MonoBehaviour
{
    private Material material;
    private AudioSource myAudioSource;
    private float newvalue;
    public float dissolveSpeed = 0.01f;
    public Material lightMat;
    public GameObject audioManager;
    public GameObject ScoreUI;
    public GameObject GameManager;
    public AudioSource PlayerAudioSource;
    public Text UIText;
    public Color emissionColour;
    public Color selectedColour;
    public Color startColour;

    // Start is called before the first frame update
    void Awake()
    {
        audioManager = GameObject.Find("AudioManager");
        material = transform.GetChild(1).GetComponent<MeshRenderer>().material;
        myAudioSource = GetComponent<AudioSource>();
        GameManager = GameObject.Find("GameManager");
        PlayerAudioSource = GameObject.Find("Camera").GetComponent<AudioSource>();
        //emissionColour = lightMat.GetColor("_EmissionColor");
        lightMat.SetColor("_EmissionColor", emissionColour);
        emissionColour = startColour;
        UIText = transform.GetChild(2).transform.GetComponentInChildren<Text>();
        UIText.text = transform.parent.GetComponent<Text>().text;
        UIText.color = startColour;

    }

    public IEnumerator Dissolve()
    {

        UIText.color = selectedColour;
        transform.GetChild(0).GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", selectedColour);
        while (material.GetFloat("_Duration") <= 3)
        {
            if (material.GetFloat("_Duration") >= 2)
            {
                Destroy(this.gameObject);
            }

            newvalue += 0.05f;
            material.SetFloat("_Duration", (newvalue));
            yield return new WaitForSeconds(0.02f);

        }

    }

    public void TokenTrigger()
    {
        myAudioSource.Play();
        //audioManager.GetComponent<AudioManager>().NextClip();
        //GetComponent<AudioTrigger>().NextClip();
        StartCoroutine("Dissolve");
        GameManager.GetComponent<GameManager>().Score();
        GetComponent<BoxCollider>().enabled = false;

    }

    public void OnMouseDown()
    {
        TokenTrigger();
        /*StartCoroutine("AudioPitchChange");
        Invoke("RevertColor", 2f);*/

    }

    IEnumerator AudioPitchChange()
    {
        PlayerAudioSource.pitch += 3;
        while (PlayerAudioSource.pitch > 1)
        {
            PlayerAudioSource.pitch = PlayerAudioSource.pitch - 0.01f;
            lightMat.SetColor("_EmissionColor", Color.red);

            if (PlayerAudioSource.pitch <= 1)
            {
                lightMat.SetColor("_EmissionColor", Color.cyan);
                break;
            }
            yield return null;
        }
    }

    IEnumerator RevertColor()
    {

        lightMat.SetColor("_EmissionColor", emissionColour);

        yield return null;
    }

    public void destroy()
    {
        StartCoroutine("AudioPitchChange");
        Invoke("RevertColor", 2f);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "plane")
        {
            UIText.color = selectedColour;
        }
    }
}


