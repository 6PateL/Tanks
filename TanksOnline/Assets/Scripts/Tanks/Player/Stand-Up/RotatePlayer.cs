using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    [SerializeField] private GameObject Player; 
    private void OnCollisionEnter(Collision other) {
        if(this.CompareTag("Stand-Up"))
        {
          Player.transform.rotation = Quaternion.identity; 
        }
    }
}
