using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footballScript : MonoBehaviour
{

    Rigidbody rb;
    public float lookSpeed = 5f;
    public float boostSpeed = 5f;
    public float boostStart = 5f;
    public float boostEnd = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        // makes football look in direction of velocity after certain speed
        if (rb.velocity.magnitude >= lookSpeed)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
        }

        // boost football speed
        if (rb.velocity.magnitude > boostStart && rb.velocity.magnitude < boostEnd)
        {
            rb.velocity += (rb.velocity * boostSpeed * Time.deltaTime);
        }
    }
}
