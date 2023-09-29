using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawn : MonoBehaviour
{
   [SerializeField] private GameObject brick;
   [SerializeField] private float time = 0f;
   [SerializeField] private float timeDelay = 60f;
    private void Update()
    {
      if(Brick.Health == 0)
      { 
        time = time + 1f * Time.deltaTime;
      }
      if(time == timeDelay && Brick.Health == 0)
      {
       brick.SetActive(true);
       Brick.Health = 10;
       time = 0f;
      }
    }
}
