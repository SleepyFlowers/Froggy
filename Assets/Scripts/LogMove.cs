using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float logDeath = -15;

    
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < logDeath)
        {
            Destroy(gameObject);
        }
    }
}
