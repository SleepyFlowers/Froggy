using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacerSpawn : MonoBehaviour
{
   public GameObject Racer;
   public float rate = 2;
   public float timer = 0;


   void start()
   {
    spawnRacer();
   }


   void Update()
   {
        if (timer < rate)
        {
            timer = timer + Time.deltaTime;
        }
        else 
        {
            spawnRacer();
            timer = 0;
        }
   }


   void spawnRacer()
   {
    Instantiate(Racer, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
   }
}
