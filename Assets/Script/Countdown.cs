using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text countdownText; 
    public PlayerController playerController; 
    // カウントダウン
    public void StartCountdown(float seconds)
    {
        StartCoroutine(CountdownCoroutine(seconds));
    }

    // カウントダウン
    private IEnumerator CountdownCoroutine(float seconds)
    {
        int count = Mathf.CeilToInt(seconds); // 切り上げて秒数を整数に変換

        while (count > 0)
        {
            countdownText.text = count.ToString();
            yield return new WaitForSeconds(1f);
            count--;
        }
        countdownText.text = "GO!";
        yield return new WaitForSeconds(1f);
        countdownText.gameObject.SetActive(false);
        playerController.StartPlayerMovement();
    }
}
