using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    [SerializeField] private float Speed;
    void Update()
    {
       transform.position += transform.forward * Time.deltaTime * Speed; 
    }

    private void OnTriggerEnter(Collider other) {
        IDamagble damagble = other.GetComponent<IDamagble>();
        if(damagble != null)
        {
          damagble.Damage();
          Destroy(gameObject); 
        }
    }
}
