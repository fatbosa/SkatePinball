using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float forceApplied = 1;
 
     void OnCollisionEnter(Collision col)
     {
         
         if (col.gameObject.name == "Bola")
         {
             Debug.Log ("Collision!");
             col.gameObject.GetComponent<Rigidbody>().velocity = col.gameObject.GetComponent<Rigidbody>().velocity + new Vector3(10,0,10);
         }
     }
}
