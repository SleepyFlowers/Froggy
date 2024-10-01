using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RakeSpawn : MonoBehaviour
{
   public GameObject Rake;
   public float rate = 2;
   public float timer = 0;


   void start()
   {
    spawnRake();
   }


   void Update()
   {
        if (timer < rate)
        {
            timer = timer + Time.deltaTime;
        }
        else 
        {
            spawnRake();
            timer = 0;
        }
   }


   void spawnRake()
   {
    Instantiate(Rake, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
   }
}
