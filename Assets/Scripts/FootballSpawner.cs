using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballSpawner : MonoBehaviour
{
    public GameObject Football;
    public GameObject spawner;
    void Start()
    {
        Vector3 position = spawner.transform.position;
        Instantiate(Football, spawner.transform.position, spawner.transform.rotation);
    }
    public void SpawnNewFootball()
    {
        GameObject spawner = GameObject.Find("FootballSpawner");
        Vector3 position = spawner.transform.position;
        position.y += 1f;
        Instantiate(Football, position, spawner.transform.rotation);
    }
}
