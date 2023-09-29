using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
  private void OnCollisionEnter(Collision other) {
     if(other.gameObject.CompareTag("Bullet"))
     {
       Destroy(other.gameObject); 
     }
  }
}
