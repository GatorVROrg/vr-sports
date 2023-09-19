using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotateInCircle : MonoBehaviour
{

    public GameObject plane;
    public GameObject island;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(island.transform.position, island.transform.up, speed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, island.transform.position, speed * Time.deltaTime);
    }
}
