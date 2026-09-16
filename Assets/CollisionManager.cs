using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    
    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("Touch Something");
    }

}
