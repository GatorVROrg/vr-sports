using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotateInCircle : MonoBehaviour
{

    public GameObject island;
    public float speed = 10f;
    public float forwardMotion = 10f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 50f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(island.transform.position, island.transform.up, speed * Time.deltaTime);
        //transform.position = Vector3.MoveTowards(transform.position, island.transform.position, speed * Time.deltaTime);
    }
}
