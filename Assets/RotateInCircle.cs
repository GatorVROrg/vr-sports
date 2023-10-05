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

    float zVelocity = 10f;
    float xVelocity = 70f;

    float theta = 0f;
    float distanceFromOrigin = 90f;

    bool xIncreasing = true;
    bool zIncreasing = true;

    bool startDescent = false;

    float originalYPos = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.velocity = new Vector3(0, 0, zVelocity);
        //originalYPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 planeRectCoords = new Vector3(transform.position.x, originalYPos, transform.position.z);

        if (startDescent)
        {
            planeRectCoords = new Vector3(transform.position.x, transform.position.y + (70 * speed * Time.deltaTime), transform.position.z);
        }

        Vector3 islandCenter = new Vector3(0f, 0f, 0f);

        Vector3 directionToIsland = islandCenter - planeRectCoords;
        rb.AddForceAtPosition(directionToIsland, transform.position);

        */

        //// Polar Coordinate Implementation(?):
        float theta = Mathf.Atan(transform.position.x / transform.position.z);
        float distanceFromOrigin = Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) + Mathf.Pow(transform.position.z, 2));
        //transform.position = new Vector3(transform.position.x - (distanceFromOrigin * Mathf.Cos(theta) * Time.deltaTime), transform.position.y - (10 * speed * Time.deltaTime), transform.position.z - (distanceFromOrigin * Mathf.Sin(theta) * Time.deltaTime));

        //rb.velocity = new Vector3(xVelocity/(speed * Time.deltaTime), 0, zVelocity/(speed * Time.deltaTime));

        // Angular Velocity Implementation:
        //float radiusDistance = Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) + Mathf.Pow(transform.position.z, 2));
        //float omegaRadians = Mathf.PI * 2f * speed * Time.deltaTime;
        //float angVelocity = omegaRadians / radiusDistance;

        //transform.position = new Vector3(transform.position.x, transform.position.y - (10 * speed * Time.deltaTime), transform.position.z);

        // Mathf.Sqrt(radiusDistance - Mathf.Pow(transform.position.x, 2))


        /*
        if (transform.position.x == 0)
        {
            //xIncreasing = false;
            transform.position = new Vector3(transform.position.x + (10 * speed * Time.deltaTime), transform.position.y - (10 * speed * Time.deltaTime), transform.position.z);
        }
        else if (transform.position.x < 0)
        {
            rb.velocity = new Vector3(xVelocity, 0, zVelocity + (10 * speed * Time.deltaTime));
            //transform.position = new Vector3(transform.position.x + (10 * speed * Time.deltaTime), transform.position.y - (10 * speed * Time.deltaTime), transform.position.z);
        }
        else
        {
            rb.velocity = new Vector3(xVelocity, 0, zVelocity - (10 * speed * Time.deltaTime));
            //transform.position = new Vector3(transform.position.x - (10 * speed * Time.deltaTime), transform.position.y - (10 * speed * Time.deltaTime), transform.position.z);
        }

        if (transform.position.z == 0)
        {
            rb.velocity = new Vector3(xVelocity, 0, zVelocity - (10 * speed * Time.deltaTime));
            //transform.position = new Vector3(transform.position.x, transform.position.y - (10 * speed * Time.deltaTime), transform.position.z + (10 * speed * Time.deltaTime));
        }
        else if (transform.position.z < 0)
        {
            rb.velocity = new Vector3(xVelocity, 0, zVelocity + (10 * speed * Time.deltaTime));
            //transform.position = new Vector3(transform.position.x, transform.position.y - (10 * speed * Time.deltaTime), transform.position.z + (10 * speed * Time.deltaTime));
        }
        else
        {
            rb.velocity = new Vector3(xVelocity, 0, zVelocity - (10 * speed * Time.deltaTime));
            //transform.position = new Vector3(transform.position.x, transform.position.y - (10 * speed * Time.deltaTime), transform.position.z - (10 * speed * Time.deltaTime));
        }
        */
        
    }
}
