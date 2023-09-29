using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem
{
  private int MaxHealth;
  private int Health;

  public void Damage(int amount)
  {
    Health -= amount; 

    if(Health < 0)
    {
      Health = 0; 
    }
  }

  public HealthSystem(int MaxHealth)
  {
    this.MaxHealth = MaxHealth;
    Health = MaxHealth; 
  }
 public void Heal(int amount) 
 { 
    Health += amount;
    if (Health > MaxHealth) 
    {
      Health = MaxHealth;
    }
 }
  public int GetHealth()
  {
    return Health; 
  }

  public int GetHealthMax()
  {
    return MaxHealth; 
  }
}
