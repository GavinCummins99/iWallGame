using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Token")
        {
            other.gameObject.GetComponent<dissolveScript>().destroy();
            Destroy(other.gameObject, 3f);
        }
            
    }

    
}
