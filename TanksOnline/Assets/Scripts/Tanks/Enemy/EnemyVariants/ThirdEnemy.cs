using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdEnemy : MonoBehaviour
{
  private Rand rand;

  [SerializeField] private float Speed = 7f;
  private float rotateDirection; 

  private float time = 0f;
  private float timeDelay = 2f; 
  [SerializeField] private GameObject Bullet;
  [SerializeField] private Transform Direction;
  [SerializeField] private AudioSource ShootSound;
  [SerializeField] private AudioClip Sound;

  private void Awake() {
     rand = new Rand(0); 
  }
  private void Update() {
    Move();
    DestroyObject();
  }
  private void Move()
  {
    transform.position += transform.forward * Time.deltaTime * Speed;
    time = time + 1f * Time.deltaTime; 
    rand.SpawnRandomNumber();
    if(time >= timeDelay)
    { 
      if(rand.GetRandomNumber() == 0)
      {
       rotateDirection = 0f;
       transform.Rotate(0f,rotateDirection,0f);
       Instantiate(Bullet,Direction.position,transform.rotation);
       ShootSound.PlayOneShot(Sound);
       time = 0f;
       
      }
      if(rand.GetRandomNumber() == 1)
      {
       rotateDirection = 90f;
       transform.Rotate(0f,rotateDirection,0f);
       Instantiate(Bullet,Direction.position,transform.rotation);
       ShootSound.PlayOneShot(Sound);
       time = 0f;
      }
     if(rand.GetRandomNumber() == 2)
     {
       rotateDirection = -90f; 
       transform.Rotate(0f,rotateDirection,0f);
       Instantiate(Bullet,Direction.position,transform.rotation);
       ShootSound.PlayOneShot(Sound);
       time = 0f;
     }
     if(rand.GetRandomNumber() == 3)
     {
       rotateDirection = 180f;
       transform.Rotate(0f,rotateDirection,0f);
       Instantiate(Bullet,Direction.position,transform.rotation);
       ShootSound.PlayOneShot(Sound);
       time = 0f;
     }
  }
 }
  private void DestroyObject()
  {
    if(ThirdHitBox.IsDestroyed)
    {
      Destroy(gameObject); 
    }
  }
}
