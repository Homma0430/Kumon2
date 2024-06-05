using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    bool isStop = false;
    public float moveSpeed = 5f; // ˆÚ“®‘¬“x


    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //TODO
        //ˆÚ“®‚¹‚æ
        //https://candle-stoplight-544.notion.site/4e021f226d584730b715626436ccc330

        _rigidBody.MovePosition(_rigidBody.position + transform.right * moveSpeed * Time.fixedDeltaTime);
    }
}