using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckSpawn : MonoBehaviour
{
   public GameObject Truck;
   public float rate = 2;
   public float timer = 0;


   void start()
   {
    spawnTruck();
   }


   void Update()
   {
        if (timer < rate)
        {
            timer = timer + Time.deltaTime;
        }
        else 
        {
            spawnTruck();
            timer = 0;
        }
   }


   void spawnTruck()
   {
    Instantiate(Truck, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
   }
}
