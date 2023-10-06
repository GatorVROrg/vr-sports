using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballSpawner : MonoBehaviour
{
    public GameObject Football;
    public void Start()
    {
        GameObject spawner = GameObject.Find("FootballSpawner");
        Instantiate(Football, spawner.transform.position, spawner.transform.rotation);
    }
    public void SpawnNewFootball()
    {
        Debug.Log("spawned football");
        GameObject spawner = GameObject.Find("FootballSpawner");
        Vector3 position = spawner.transform.position;
        Instantiate(Football, position, spawner.transform.rotation);
    }
}
