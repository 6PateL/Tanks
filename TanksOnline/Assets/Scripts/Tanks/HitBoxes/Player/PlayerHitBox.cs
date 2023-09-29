using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHitBox : MonoBehaviour,IDamagble
{
   private HealthSystem healthSystem;
   [SerializeField] private Slider CurrentHP;
   public static int CurrentTankHealth = 100;
   [SerializeField] private GameObject Player;
   [SerializeField] private AudioSource ShootSound;
   [SerializeField] private AudioClip DamageSound;
   [SerializeField] private AudioClip WaterSound;

    private void Awake() {
      CurrentTankHealth = 100; 
    }
    private void Update()
    {
      CurrentHP.value = CurrentTankHealth;
    }
    private void OnTriggerEnter(Collider other) 
    {
      if(this.CompareTag("Tank") && other.CompareTag("Water"))
        CurrentTankHealth = 0;
        ShootSound.PlayOneShot(WaterSound);
      if(CurrentTankHealth == 0)
      {
        Player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
      }
    }
    public void Damage()
    {
      int Damageamount = Random.Range(10,20); 
      CurrentTankDamage(Damageamount);
      ShootSound.PlayOneShot(DamageSound);
    }

    public void CurrentTankDamage(int amount)
    {
      CurrentTankHealth -= amount;
      if(CurrentTankHealth < 0)
      {
        CurrentTankHealth = 0;
      }
    }
}
