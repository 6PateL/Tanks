using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelector : MonoBehaviour
{
  public void StartGame()
  {
    SceneManager.LoadScene(1);
  }
}
