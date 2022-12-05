using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
//This Script goes on the spawn points of the tokens
public class TokenScript : MonoBehaviour
{
    public bool ready = false;
    public GameObject Token;
    public GameObject GameManager;
    
    private Transform SpawnPosition;
    public GameObject[] Tokens;
    private int rand;
    private GameObject TokenTextObject;
    

    // Start is called before the first frame update
    public void SpawnToken()
    {
            
            rand = Random.Range(0, Tokens.Length);
            Token = Tokens[rand];
            
        //Token.GetComponent<dissolveScript>().UIText.GetComponent<Text>().text = SpawnPosition.GetComponent<Text>().text;
        Instantiate(Token, SpawnPosition);
            
            GetComponentInChildren<TokenController>().Leen();
       
        Debug.Log("Spawned");
    }

    void Start()
    {
        SpawnPosition = this.gameObject.transform;
        int Children = transform.childCount;
        
    }

    private void Update()
    {
        if(transform.childCount > 1)
        {
            ready = false;
        }
        else
        {
            ready = true;
        }
        
    }

}
