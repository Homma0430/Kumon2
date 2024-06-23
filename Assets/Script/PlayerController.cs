using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Move moveScript; // Player の動きを制御する Move スクリプトへの参照
    public Countdown countdown; // カウントダウンを制御する Countdown スクリプトへの参照
    public float startDelay = 3f; // カウントダウンの遅延時間

    void Start()
    {
        // カウントダウンを開始する
        countdown.StartCountdown(startDelay);
    }

    // カウントダウンが終了したら呼ばれるメソッド
    public void StartPlayerMovement()
    {
        // Move スクリプトの StartMovement メソッドを呼び出して Player の動きを開始する
        moveScript.StartMovement();
    }
}
