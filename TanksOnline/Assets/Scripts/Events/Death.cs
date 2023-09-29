using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
  [SerializeField] private GameObject Player;
  [SerializeField] private GameObject PlayerBase; 

  [SerializeField] private GameObject HUD;
  [SerializeField] private GameObject DeathUI;
  [SerializeField] private GameObject DeathUIWithoutBase; 
  private void Update() {
     if(PlayerHitBox.CurrentTankHealth == 0 && PlayerBase == null && Base.IsDestoroyed == true)
     {
       HUD.SetActive(false); 
       DeathUIWithoutBase.SetActive(true);
     }
     else if(PlayerHitBox.CurrentTankHealth == 0)
     {
       HUD.SetActive(false);
       DeathUI.SetActive(true);
     }
  }
}
