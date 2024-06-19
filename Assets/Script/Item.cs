using UnityEngine;

public class Item: MonoBehaviour
{
    public int scoreIncrement = 1; 
    void OnTriggerEnter(Collider other)
    {        
        ScoreManager.Instance.AddScore(scoreIncrement);
        Destroy(gameObject);
    }
}
