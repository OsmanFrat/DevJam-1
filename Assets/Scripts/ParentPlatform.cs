using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        other.transform.SetParent(transform);
        Debug.Log("parent");
    }

    private void OnCollisionExit(Collision other)
    {
       other.transform.SetParent(null);
       Debug.Log("parent null");
    }
}
