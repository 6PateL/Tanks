using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
  [SerializeField] private AudioSource ClickSound;
  [SerializeField] private AudioClip Click;
  public void Quit()
  {
    Application.Quit();
    ClickSound.PlayOneShot(Click); 
  }
}
