using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rand
{
  private int randomNumber;
  public int GetRandomNumber()
  {
    return randomNumber; 
  }
  public void SpawnRandomNumber()
  {
    randomNumber = Random.Range(0,3); 
  }
  public Rand(int randomNumber)
  {
    this.randomNumber = randomNumber; 
  }
}
