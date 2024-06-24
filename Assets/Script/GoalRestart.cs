using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoalRestart : MonoBehaviour
{
    // 接触を検知する対象のタグ
    public string targetTag;

    // 遅延時間（秒）
    public float delay = 2.0f;

    // 衝突を検知するメソッド
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            StartCoroutine(ReloadSceneAfterDelay());
        }
    }

    // コルーチン：指定した秒数後にシーンを再読み込み
    private IEnumerator ReloadSceneAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
