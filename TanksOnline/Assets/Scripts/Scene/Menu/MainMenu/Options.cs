using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
  private float change = 4f;

  private void Awake() {
    change = PlayerPrefs.GetFloat("SentivityOptions"); 
  }
  private void Update() {
    PlayerPrefs.SetFloat("SentivityOptions",change);  
  }
  public void Sentivity(float sentivity)
  {
    change = sentivity;
  }
}
