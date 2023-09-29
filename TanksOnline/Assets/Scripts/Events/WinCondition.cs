using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class WinCondition : MonoBehaviour
{
  [SerializeField] private Text NeedToKill;
  [SerializeField] private GameObject Win;
  [SerializeField] private GameObject MainUI; 
  public static int KillsToWin = 30; 
  public void LeftEnemyDecrease()
  {
    KillsToWin--;
  }
  public int EnemysLeft()
  {
    return KillsToWin;  
  }

  private void Update() {
     NeedToKill.text = "" + KillsToWin;
     if(KillsToWin <= 0)
     {
      Cursor.lockState = CursorLockMode.None;
       MainUI.SetActive(false);
       Win.SetActive(true);
       Time.timeScale = 0; 
     }
  }
}
