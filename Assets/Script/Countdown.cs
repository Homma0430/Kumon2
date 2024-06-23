using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text countdownText; 
    public PlayerController playerController; 
    // �J�E���g�_�E��
    public void StartCountdown(float seconds)
    {
        StartCoroutine(CountdownCoroutine(seconds));
    }

    // �J�E���g�_�E��
    private IEnumerator CountdownCoroutine(float seconds)
    {
        int count = Mathf.CeilToInt(seconds); // �؂�グ�ĕb���𐮐��ɕϊ�

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
