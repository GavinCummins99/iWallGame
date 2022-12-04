using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "token")
        {
            Destroy(collider.gameObject);
            Debug.Log("Destoryed");
        }
    }
}
