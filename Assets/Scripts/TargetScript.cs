using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TargetScript : MonoBehaviour
{
    public GameObject[] footballs;
    public GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        footballs = GameObject.FindGameObjectsWithTag("Football");

        foreach (GameObject football in footballs)
        {
            float distance = Vector3.Distance(this.transform.position, football.transform.position);
            if(distance <= 1)
            {
                football.GetComponent<footballScript>().owner.GetComponent<ScoreKeeper>().Score++;
                Destroy(this.gameObject);
            }
        }
    }
}
