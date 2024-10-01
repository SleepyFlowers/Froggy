using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turtDeath = -15;

    
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < turtDeath)
        {
            Destroy(gameObject);
        }
    }
}
