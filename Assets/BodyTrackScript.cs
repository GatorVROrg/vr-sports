using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyTrackScript : MonoBehaviour
{
    public Transform headTransform; // Reference to the head GameObject
    public Transform bodyTransform; // Reference to the body GameObject

    public float distanceToHead = 1.0f; // Distance between head and body on the y-axis

    private void Update()
    {
        // Get the head's position
        Vector3 headPosition = headTransform.position;

        // Update the body's position to match the head but with an offset on the y-axis
        Vector3 bodyPosition = new Vector3(headPosition.x, headPosition.y - distanceToHead, headPosition.z);

        // Set the body's position
        bodyTransform.position = bodyPosition;

        // Rotate the body only on the y-axis to match the head's rotation
        bodyTransform.rotation = Quaternion.Euler(0, headTransform.rotation.eulerAngles.y, 0);
    }
}