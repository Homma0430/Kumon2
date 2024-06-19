using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStop: MonoBehaviour
{
    public string targetTag = "Target"; // ターゲットのタグ

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
