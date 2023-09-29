using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdHitBox : MonoBehaviour,IDamagble
{
 private HealthSystem healthSystem;
 [SerializeField] private AudioClip DamageSound;
 [SerializeField] private AudioSource ShootSound;
 public static bool IsDestroyed = false;

  private void Awake() {
    healthSystem = new HealthSystem(130);
  }
  private void Update()
  {
    DestroyEnemy();  
  }
  private void DestroyEnemy()
  {
    if(healthSystem.GetHealth() <= 0)
    {
      WinCondition.KillsToWin--;
      IsDestroyed = true; 
    }
  }
    private void OnTriggerEnter(Collider other) {
     if(other.gameObject.CompareTag("Water"))
     {
       IsDestroyed = true;
     }
    }
  public void Damage()
  {
    int DamageDealing = Random.Range(10,50);
    healthSystem.Damage(DamageDealing);
    ShootSound.PlayOneShot(DamageSound);
  }
}
