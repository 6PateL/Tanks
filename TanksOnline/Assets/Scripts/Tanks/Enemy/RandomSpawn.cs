using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private Transform[] TankSpots; 
    [SerializeField] private GameObject[] Tanks; 
    private int amount;

    private int RandomSpawnTankSpots, RandomSpawnTanks; 
    [SerializeField] private float StartTankWaitTime;
    private float TankWaitTime;

    private void Start()
    {
       RandomSpawnTankSpots = Random.Range(0, TankSpots.Length);
       RandomSpawnTanks = Random.Range(0, Tanks.Length); 

       TankWaitTime = StartTankWaitTime;
    }

    private void Update()
    {
      SpawnTanks(); 
    }

    private void SpawnTanks()
    {
      if(TankWaitTime < 0 && amount <= 15)
      {
         Instantiate(Tanks[RandomSpawnTanks],TankSpots[RandomSpawnTankSpots].position,transform.rotation);
         RandomSpawnTankSpots = Random.Range(0, TankSpots.Length);
         RandomSpawnTanks = Random.Range(0, Tanks.Length); 
         amount++; 
         TankWaitTime = StartTankWaitTime;        
      }
      else
      {
         TankWaitTime -= Time.deltaTime;
      }
    }
}