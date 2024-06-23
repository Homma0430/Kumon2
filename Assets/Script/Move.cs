using System.Collections;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    bool isStop = true; 
    public float moveSpeed = 5f;
    public float horizontalMoveSpeed = 3f;
    public UIManager uiManager;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    
    public void StartMovement()
    {
        isStop = false;
    }

    void FixedUpdate()
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

            Vector3 forwardMove = transform.right * moveSpeed * Time.fixedDeltaTime;
            Vector3 horizontalMove = transform.forward * horizontalInput * horizontalMoveSpeed * Time.fixedDeltaTime;
            Vector3 move = forwardMove + horizontalMove;
            _rigidBody.MovePosition(_rigidBody.position + move);
        }
    }

    public void StopMovement()
    {
        isStop = true;
        uiManager.ShowClearPanel();
    }
}
