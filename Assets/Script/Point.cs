using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public Text scoreText;

    void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = "" + ScoreManager.Instance.Score;
        }
    }
}
