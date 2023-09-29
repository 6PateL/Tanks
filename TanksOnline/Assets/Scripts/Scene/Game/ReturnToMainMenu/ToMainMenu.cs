using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ToMainMenu : MonoBehaviour
{
  [SerializeField] private GameObject HUD; 
  [SerializeField] private GameObject DeathScene;
  [SerializeField] private GameObject DeathSceneWithoutBase;
  [SerializeField] private GameObject Win;
  public void MainMenu()
  {
    SceneManager.LoadScene(0);
    HUD.SetActive(true);
    DeathScene.SetActive(false);
    DeathSceneWithoutBase.SetActive(false);
    Win.SetActive(false);
  }
}
