using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
 [SerializeField] private GameObject ModeSelectPanel;
 [SerializeField] private GameObject Options;
 [SerializeField] private GameObject Menu;
 [SerializeField] private AudioSource ClickSound;
 [SerializeField] private AudioClip Click;

 public void ModeSelection()
 {
   Menu.SetActive(false); 
   ModeSelectPanel.SetActive(true);
   ClickSound.PlayOneShot(Click);
 }
 public void  ToOptions()
 {
   Menu.SetActive(false);
   Options.SetActive(true);
   ClickSound.PlayOneShot(Click);
 }
 public void BackToMenu()
 {
  ModeSelectPanel.SetActive(false);
  Options.SetActive(false);
  Menu.SetActive(true);
  ClickSound.PlayOneShot(Click);
 }
}
