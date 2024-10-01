using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCarMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float carDeath = 15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;

        if (transform.position.x > carDeath)
        {
            Destroy(gameObject);
        }
    }
}
