using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
  private AudioSource music;
  private float change = 1f;

  private void Awake() {
    change = PlayerPrefs.GetFloat("VolumeValue");
  }
  private void Start() {
    music = GetComponent<AudioSource>();
  }
  private void Update() {
    music.volume = change;
    PlayerPrefs.SetFloat("VolumeValue",change);
  }

  public void ChangeVolume(float vol)
  {
    change = vol;
  }
}
