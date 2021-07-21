using System.Collections;
using System;    
using System.Collections.Generic;
using UnityEngine;

public class Returner : MonoBehaviour
{   
    public float forceApplied = 10;

    void OnCollisionEnter(Collision col)
     {
         

         if (col.gameObject.name == "Bola")
         {
             Debug.Log ("Collision!");
             Vector3 direction = col.contacts[0].point - transform.position;
             direction = -direction.normalized;
             col.gameObject.GetComponent<Rigidbody>().AddForce(direction*forceApplied, ForceMode.Impulse);
         }
     }

}
