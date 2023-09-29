using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolution : MonoBehaviour
{
   [SerializeField] private GameObject OnButton;
   public void WindowModeOn()
   {
     Screen.fullScreen = false; 
     OnButton.SetActive(true); 
   }
   public void WindowModeOff()
   {
     Screen.fullScreen = Screen.fullScreen;
     OnButton.SetActive(false); 
   } 
}
