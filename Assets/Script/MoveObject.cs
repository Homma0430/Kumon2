using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MoveObject : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.0f;    
    [SerializeField]
    private float moveDistance = 3.0f;
    [SerializeField]
    private bool startMovingRight = true; // ‰ŠúˆÚ“®•ûŒüitrue‚È‚ç‰EAfalse‚È‚ç¶)
    private Vector3 startPosition;   
    private float directionModifier; 

    void Start()
    {
        startPosition = transform.position;
        directionModifier = startMovingRight ? 1.0f : -1.0f;
    }

    void Update()
    {
        Vector3 newPosition = startPosition;
        newPosition.z += Mathf.PingPong(Time.time * speed, moveDistance) * directionModifier - (moveDistance / 2) * directionModifier;

        transform.position = newPosition;
    }
}
