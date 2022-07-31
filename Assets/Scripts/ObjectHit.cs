using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) 
   {
      if(other.gameObject.tag == "Player")
      {
      GetComponent<MeshRenderer>().material.color = Color.gray;
      //this gets the mesh renderer material color and changes it to the color after the dot
      }
   }
}
