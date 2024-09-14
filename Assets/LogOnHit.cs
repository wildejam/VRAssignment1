using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogOnHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Target")
        {
            Destroy(other.gameObject);
        }
    }
}
