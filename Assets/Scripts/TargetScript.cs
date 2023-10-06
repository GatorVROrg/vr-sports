using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Animations;

public class TargetScript : MonoBehaviour
{
    public GameObject[] footballs;
    public GameManager gameManager;
    void Start()
    {
        GameObject gameManager = GameObject.Find("GameManager");
    }
    void Update()
    {
        footballs = GameObject.FindGameObjectsWithTag("Football");

        foreach (GameObject football in footballs)
        {
            float distance = Vector3.Distance(this.transform.position, football.transform.position);
            if(distance <= 1)
            {
                gameManager.Player1Score++;
            }
        }
    }
}
