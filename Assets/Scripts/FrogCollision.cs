using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogCollision : MonoBehaviour
{

    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
        Debug.Log("Starting position set ");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            Debug.Log("DED FORG");
            GameManager.Instance.RespawnFrog(gameObject, startingPosition);
            gameObject.SetActive(false); //disappears the frog
        }
    }

}


