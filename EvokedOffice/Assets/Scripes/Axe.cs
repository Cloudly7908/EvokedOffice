using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Wood"))
        {
         
        }

    }
    void Update()
    {
        
    }
}
