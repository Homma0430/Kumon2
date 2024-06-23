using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject clearPanel;

    void Start()
    {
        gameOverPanel.SetActive(false);
        clearPanel.SetActive(false);
    }

    // Game Over �p�l����\������
    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

    // Clear �p�l����\������
    public void ShowClearPanel()
    {
        clearPanel.SetActive(true);
    }

    // �J�E���g�_�E���₻�̑�UI����̂��߂̃��\�b�h��ǉ�����ꍇ�͂����ɋL�q����
}
