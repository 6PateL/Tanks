using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
   [SerializeField] private GameObject brick;  
   public static int Health = 10;
   [SerializeField] private int health;

   [SerializeField] private AudioClip Sound; 
   [SerializeField] private AudioSource IDamageTaken;

   private void Awake() {
     Health = health;
   }
    private void OnCollisionEnter(Collision other) {
         if(other.gameObject.CompareTag("Bullet"))
         {
            Destroy(other.gameObject);
            IDamageTaken.PlayOneShot(Sound);
            health--; 
            if(health == 0)
            {
              brick.SetActive(false); 
              Destroy(other.gameObject);
              IDamageTaken.PlayOneShot(Sound);
            }
         }
    }
}
