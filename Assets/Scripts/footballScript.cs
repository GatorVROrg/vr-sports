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
    
    public GameObject owner; 
    public GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

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

    public void SetOwner()
    {
        // Initialize variables to keep track of the closest player and the minimum distance
        GameObject closestPlayer = null;
        float minDistance = Mathf.Infinity;

        foreach (GameObject player in players)
        {
            // Calculate the distance between the object and the current player
            float distance = Vector3.Distance(transform.position, player.transform.position);

            // Check if this player is closer than the previous closest player
            if (distance < minDistance)
            {
                minDistance = distance; // Update the minimum distance
                closestPlayer = player; // Update the closest player
            }
        }

        // Now, 'closestPlayer' contains the GameObject of the closest player.
        // You can do further actions with this player if needed.

        // For example, assign the closest player as the owner
        owner = closestPlayer;
    }
}
