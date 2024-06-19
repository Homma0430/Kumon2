using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    bool isStop = false;
    public float moveSpeed = 5f; 
    public float horizontalMoveSpeed = 3f; 
    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (!isStop)
        {
            float horizontalInput = 0f;
            if (Input.GetKey(KeyCode.D))
            {
                horizontalInput = -1f;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                horizontalInput = 1f;
            }
            Vector3 forwardMove = transform.right * moveSpeed * Time.deltaTime;
            Vector3 horizontalMove = transform.forward * horizontalInput * horizontalMoveSpeed * Time.deltaTime;
            Vector3 move = forwardMove + horizontalMove;
            _rigidBody.MovePosition(_rigidBody.position + move);
        }
    }

    public void StopMovement()
    {
        isStop = true;
    }
}
