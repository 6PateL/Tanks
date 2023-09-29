using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneSelecter : MonoBehaviour
{
  public void LevelSelect(int lvl)
  {
    SceneManager.LoadScene(lvl);
  }
  //Singleton must have =) 
}
