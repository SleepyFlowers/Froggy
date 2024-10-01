using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkSpawn : MonoBehaviour
{
   public GameObject PinkCar;
   public float rate = 2;
   public float timer = 0;


   void start()
   {
    spawnCar();
   }


   void Update()
   {
        if (timer < rate)
        {
            timer = timer + Time.deltaTime;
        }
        else 
        {
            spawnCar();
            timer = 0;
        }
   }


   void spawnCar()
   {
    Instantiate(PinkCar, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
   }
}
