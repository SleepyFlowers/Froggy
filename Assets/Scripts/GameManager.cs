using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    public void RespawnFrog(GameObject Froggy, Vector3 startingPosition)
    {
        StartCoroutine(RespawnCoroutine(Froggy, startingPosition));
    }

    private IEnumerator RespawnCoroutine(GameObject Froggy, Vector3 startingPosition)
    {
        Debug.Log("got hit");
        yield return new WaitForSeconds(1f);

        Froggy.transform.position = startingPosition;
        Debug.Log("right back");

        Froggy.SetActive(true);
        Debug.Log("He lives"); // jeez i hope this is how coroutines work
    }
}