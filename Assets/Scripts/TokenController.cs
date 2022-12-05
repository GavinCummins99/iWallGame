using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 // This script goes on the tokens
public class TokenController : MonoBehaviour
{
    public bool ready = false;
    public bool selected = false;
    public GameObject GameManager;
    private Transform Destination;
    AudioSource audioSource;
    // Start is called before the first frame update

    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
    }
    public void Leen()
    {
        //Destination = Target.transform;
        LeanTween.moveLocalX(this.gameObject,40f, 10f);
    }

    

   

}
