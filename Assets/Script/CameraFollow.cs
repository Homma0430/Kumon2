using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    public float smoothSpeed = 0.125f;
    public float heightOffset = 2.0f;
    public Vector3 rotationOffset = new Vector3(45, 0, 0);

    void Start()
    {
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        if (target != null)
        {         
            Vector3 desiredPosition = target.position + offset + new Vector3(0, heightOffset, 0);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.rotation = Quaternion.Euler(rotationOffset);
        }
    }
}
