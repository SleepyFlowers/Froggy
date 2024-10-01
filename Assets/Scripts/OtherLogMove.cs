using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherLogMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float logDeath = 15;

    
    void Update()
    {
        transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;

        if (transform.position.x > logDeath)
        {
            Destroy(gameObject);
        }
    }
}
