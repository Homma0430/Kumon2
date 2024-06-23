using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Move moveScript; 
    public Countdown countdown; 
    public float startDelay = 3f; 

    void Start()
    {
        
        countdown.StartCountdown(startDelay);
    }

    
    public void StartPlayerMovement()
    {
        
        moveScript.StartMovement();
    }
}
