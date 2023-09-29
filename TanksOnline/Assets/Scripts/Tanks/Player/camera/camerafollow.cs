using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camerafollow : MonoBehaviour
{
    [SerializeField] private Transform Direction;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float Sensivity; 

    private void Start() {
      Cursor.lockState = CursorLockMode.Locked;
      float Music = PlayerPrefs.GetFloat("VolumeValue");
      float Sentivity = PlayerPrefs.GetFloat("SentivityOptions");
    }
    private void LateUpdate()
    {
       transform.position = Direction.position + offset;
       float r = Input.GetAxisRaw("Mouse X");
       transform.Rotate(0,r*Sensivity,0);
       if(Input.GetKeyDown(KeyCode.Escape))
       {
         Cursor.lockState = CursorLockMode.None;
       }
    }
}
