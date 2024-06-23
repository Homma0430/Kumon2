using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public int Score { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        
        InitializeScore();
    }

    private void InitializeScore()
    {
        Score = 0; 
    }

    public void AddScore(int points)
    {
        Score += points;
        Debug.Log("" + Score);
    }
}
