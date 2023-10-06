using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballSpawner : MonoBehaviour
{
    public GameObject Football;
    public GameObject spawner;
    void Start()
    {
        Instantiate(Football, spawner.transform.position, spawner.transform.rotation);
    }
    public void SpawnNewFootball()
    {
        Instantiate(Football, spawner.transform.position, spawner.transform.rotation);
    }
}
