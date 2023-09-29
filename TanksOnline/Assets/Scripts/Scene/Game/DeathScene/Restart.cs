using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
  [SerializeField] private GameObject Player;
  [SerializeField] private GameObject DeathScene;
  [SerializeField] private GameObject HUD;
  [SerializeField] private Transform PlayerDirection;
  [SerializeField] private Vector3 Direction;

  public void RestartGame()
  {
     Player.SetActive(true);
     HUD.SetActive(true); 
     Player.transform.position = PlayerDirection.position + Direction;
     PlayerHitBox.CurrentTankHealth = 100; 
     Cursor.lockState = CursorLockMode.Locked;
     DeathScene.SetActive(false);
  }
}
