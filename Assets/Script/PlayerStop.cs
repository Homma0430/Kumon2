using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStop: MonoBehaviour
{
    public string targetTag = "Target"; 

    private Move moveScript;

    void Start()
    {
        moveScript = GetComponent<Move>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            moveScript.StopMovement();
        }
    }
}
