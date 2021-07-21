using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer2 : MonoBehaviour
{
 
     void OnCollisionEnter(Collision col)
     {
         
         if (col.gameObject.name == "Bola")
         {
             Debug.Log ("Collision!");
             col.gameObject.GetComponent<Rigidbody>().velocity = col.gameObject.GetComponent<Rigidbody>().velocity + new Vector3(-10,0,10);
         }
     }
}
