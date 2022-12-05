using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalScript : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Update is called once per frame
    public void Anim()
    {
        GetComponent<Animator>().SetTrigger("Open");
        GetComponent<Animator>().SetBool("Open2", true);
        Debug.Log("Im Working");
       
    }
}
