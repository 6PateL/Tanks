using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float Speed;

    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform _BulletDirection;
    [SerializeField] private AudioClip Sound;
    [SerializeField] private AudioSource ShootSound;
    private float Sentivity = 4f; 

    private float time,timeDelay;
    [SerializeField] private Vector3 offset;
    [SerializeField] private AudioClip JoJo;
    [SerializeField] private AudioClip Dio; 
    [SerializeField] private GameObject Mask;
    public float time1 = 0f;
    public float timeDelay1 = 5f;
    public static int IsMask = 0; 

    private void Awake() {
      time = 0f; 
      timeDelay = 0.3f;
    }
    private void Update()
    {
      Move(); 
      TankRotate(); 
      Shoot();
      MaskEquiped();
      time = time + 1f * Time.deltaTime;
    }

    private void Move()
    {
       if(Input.GetKey(KeyCode.W))
       {
         transform.position += transform.forward * Speed * Time.deltaTime;
       }
      if(Input.GetKey(KeyCode.S))
       {
         transform.position += -transform.forward * Speed * Time.deltaTime;
       }

       if(Input.GetKey(KeyCode.LeftShift))
       {
         Speed = 16f; 
       }
       else
       {
         Speed = 8f;
       }
    }
    
    private void TankRotate()
    {
       float r = Input.GetAxisRaw("Horizontal");
       transform.Rotate(0f,r*Sentivity,0f); 
    }

    private void Shoot()
    {
      if(Input.GetKeyDown(KeyCode.Mouse0) && time >= timeDelay && HUDMenu.InMenu == false)
      {
         Instantiate(Bullet,_BulletDirection.position,transform.rotation);
         ShootSound.PlayOneShot(Sound);
         time = 0f;         
      }
    }

   private void MaskEquiped()
   {
      if(IsMask == 1)
      { 
         time1 = time1 + 1f * Time.deltaTime; 
         if(time1 >= timeDelay1)
         {
           ShootSound.PlayOneShot(Dio);
           time1 = 0f;
         }
       }
   }

    private void OnCollisionEnter(Collision other) {
      if(other.gameObject.CompareTag("Brick") || other.gameObject.CompareTag("Tree"))
      {
         transform.position = transform.position + offset; 
      }
    }

    private void OnTriggerEnter(Collider other) {
      if(other.CompareTag("Jo-Jo"))
      {
        Destroy(other.gameObject);
        ShootSound.PlayOneShot(JoJo);
        Mask.SetActive(true);
        IsMask = 1;
      }
    }
}