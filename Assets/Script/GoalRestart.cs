using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoalRestart : MonoBehaviour
{
    // �ڐG�����m����Ώۂ̃^�O
    public string targetTag;

    // �x�����ԁi�b�j
    public float delay = 2.0f;

    // �Փ˂����m���郁�\�b�h
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            StartCoroutine(ReloadSceneAfterDelay());
        }
    }

    // �R���[�`���F�w�肵���b����ɃV�[�����ēǂݍ���
    private IEnumerator ReloadSceneAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
