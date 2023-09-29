using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Base : MonoBehaviour,IDamagble
{
  private HealthSystem healthSystem;
  [SerializeField] private Slider CurrentBaseHp;
  [SerializeField] private AudioSource ShootSound;
  [SerializeField] private AudioClip DamageTake; 
  public static bool IsDestoroyed; 

  private void Awake() {
    healthSystem = new HealthSystem(100);
    IsDestoroyed = false; 
  }
  private void Update() 
  {
    CurrentBaseHp.value = healthSystem.GetHealth();
    if(healthSystem.GetHealth() == 0)
    {
      Destroy(gameObject);
      IsDestoroyed = true; 
    }
  }

  public void Damage()
  {
    int Damageamount = 5;
    healthSystem.Damage(Damageamount);
    ShootSound.PlayOneShot(DamageTake);
  }
}
