using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class HUDMenu : MonoBehaviour
{
  [SerializeField] private GameObject HUD;
  [SerializeField] private GameObject HUDMENU;
  [SerializeField] private AudioSource ClickSound;
  [SerializeField] private AudioClip Click;
  public static bool InMenu = false; 

  public void OptionsInGame()
  {
    HUD.SetActive(false);
    HUDMENU.SetActive(true);
    ClickSound.PlayOneShot(Click);
    InMenu = true; 
  }
  public void ReturnToGame()
  {
    HUD.SetActive(true);
    HUDMENU.SetActive(false);
    ClickSound.PlayOneShot(Click);
    Cursor.lockState = CursorLockMode.Locked;
    InMenu = false;
  }
  public void RestartLevel()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
