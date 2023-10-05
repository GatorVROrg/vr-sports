using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public bool timeToDie;
    void Update()
    {
        if(timeToDie)
        {
            Destroy(gameObject, 5f);
        }
    }

    public void TimeToDie()
    {
        timeToDie = true;
    }
}
